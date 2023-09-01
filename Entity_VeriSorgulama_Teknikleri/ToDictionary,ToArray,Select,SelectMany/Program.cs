using Entity_VeriGetirme.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Entity_VeriGetirme
{
	internal class Program
	{
		static async void Main(string[] args)
		{
			ETicaretDbContext context = new();
			#region Sorgu Sonucu Dönüşüm Fonksiyonları
			//Bu fonksiyonlar ile sorgu neticesinde elde edilen verileri isteğimiz doğrultusunda farklı türlerde projeksiyon edebiliyoruz.


			#region ToDictionary
			//Sorgu neticesinde gelecek olan veriyi bir dictionary olarak elde etmek/tutmak veya karşılamak istiyorsak eğer kullanılır.
			var urunler = await context.Urunler.ToDictionaryAsync(u=>u.UrunAdi, u=>u.Fiyat);

			//ToList ile aynı amaca hizmet etmektedir.Yani, oluşturulan sorguyu execute edip neticesini alırlar.


			#endregion

			#region ToArray
			//Oluşturulan sorguyu dizi olarak elde eder.
			//ToList ile aynıdır.Yani sorguyu execute eder ama gelen sonucu entity dizisi olarak elde eder.
			var urunler2 = await context.Urunler.ToArrayAsync();


			#endregion

			#region Select
			//Select fonksiyonu, generate edilecek sorgunun çekilecek kolonlarını ayarlamamızı sağlamaktadır.

			var urunler3 = await context.Urunler.Select(u=>new Urun
			{ UrunID=u.UrunID,
			Fiyat=u.Fiyat}).ToListAsync();

			//2.Select fonksiyonu, gelen verileri farklı türlerde karşılamamızı sağlar.T,anonim

			var urunler4 = await context.Urunler.Select(u => new Urun 
			{
				UrunID = u.UrunID,
				Fiyat = u.Fiyat
			}).ToListAsync();

			#endregion

			#region SelectMany
			//Select ile aynı amaca hizmet eder.İlişkisel tablolar neticesinde gelen verileri de çekmemizi sağlar.

			var urunler5 = context.Urunler.Include(u => u.Parcalar).SelectMany(u => u.Parcalar, (u, p) => new
			{
				u.UrunID,
				u.Fiyat,
				p.ParcaID
			}).ToList();

			#endregion

			#endregion
		}
	}
}