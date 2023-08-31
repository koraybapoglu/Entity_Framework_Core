using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Entity_VeriGetirme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ETicaretDbContext context = new();
			#region Tekil Veri Getiren Sorgulama Fonksiyonları
			//Yapılan sorguda sade ve sadece tek bir verinin gelmesi amaçlanıyorsa Single ya da SingleOrDefault fonksiyonları kullanılabilir.
			#region Single
			//Sorgu çalıştığında birden fazla veri geliyorsa ya da hiç gelmiyorsa her iki durumda da exception hatası verir.

			#region Tek Kayıt Geldiğinde
			var urun = context.Urunler.Single(u => u.UrunID == 61);
			Console.WriteLine(urun.UrunID);
			Console.WriteLine(urun.UrunAdi);
			Console.WriteLine(urun.Fiyat);
			#endregion

			#region Hiç Kayıt Gelmediğinde
			var urun2 = context.Urunler.Single(u => u.UrunID == -16);
			//EXCEPTİON HATASI.
			#endregion

			#region Çok Kayıt Geldiğinde
			var urun3 = context.Urunler.Single(u => u.UrunAdi.StartsWith("U"));
			//EXCEPTİON HATASI.
			#endregion

			#endregion

			#region SingleOrDefault
			//Sorgu çalıştığında birden fazla veri geliyorsa exception,hiç veri gelmiyorsa null değeri döner.
			#region Tek Kayıt Geldiğinde
			var urun4 = context.Urunler.SingleOrDefault(u => u.UrunID == 61);
			Console.WriteLine(urun.UrunID);
			Console.WriteLine(urun.UrunAdi);
			Console.WriteLine(urun.Fiyat);
			#endregion

			#region Hiç Kayıt Gelmediğinde
			var urun5 = context.Urunler.SingleOrDefault(u => u.UrunID == -16);
			//NULL DEĞER.
			#endregion

			#region Çok Kayıt Geldiğinde
			var urun6 = context.Urunler.SingleOrDefault(u => u.UrunAdi.StartsWith("U"));
			//EXCEPTİON HATASI.
			#endregion

			#endregion

			#region First
			//Sorgu neticesinde elde edilen verilerden ilkini getirir.Eğer ki hiç veri gelmiyorsa  hata fırlatır.

			#region Tek Kayıt Geldiğinde

			var urun7 = context.Urunler.First(u => u.UrunID == 61);
			Console.WriteLine(urun.UrunID);
			Console.WriteLine(urun.UrunAdi);
			Console.WriteLine(urun.Fiyat);

			#endregion

			#region Çok Kayıt Geldiğinde

			var urun8 = context.Urunler.First(u => u.UrunAdi.StartsWith("U"));
			//İLK VERİ GELDİ.

			#endregion

			#region Hiç Kayıt Gelmediğinde

			var urun9 = context.Urunler.First(u => u.UrunID == -16);
			//EXCEPTİON HATASI
			#endregion

			#endregion

			#region FirstOrDefault
			//Sorgu neticesinde elde edilen verilerden ilkini getirir. Eğer ki hiç veri gelmiyorsa null değerini döndürür.

			#region Tek Kayıt Geldiğinde

			var urun10 = context.Urunler.FirstOrDefault(u => u.UrunID == 61);
			Console.WriteLine(urun.UrunID);
			Console.WriteLine(urun.UrunAdi);
			Console.WriteLine(urun.Fiyat);
			#endregion

			#region Çok Kayıt Geldiğinde

			var urun11 = context.Urunler.FirstOrDefault(u => u.UrunAdi.StartsWith("U"));
			//İLK VERİ GELDİ.
			#endregion

			#region Hiç Kayıt Gelmediğinde

			var urun12 = context.Urunler.First(u => u.UrunID == -16);
			//Null Değer
			#endregion

			#endregion

			#region Find
			//TEKİL SORGULARIMIZI GENELLİKLE ID(PRİMARY KEY) ÜZERİNDEN SORGULAMA YAPIYORUZ VE ONA GÖRE ÇALIŞMA DÜZENLİYORUZ.

			Entities.Urun urun13 = context.Urunler.FirstOrDefault(u => u.UrunID == 55);

			Entities.Urun urun14 = context.Urunler.Find(55); //55'ID Numaralı ürünü bizlere getirir.

			//Hızlı bir şekilde sorgulamamızı yapmış olduk.

			//Composite Primary Key olarakda kullanabiliyoruz.

			//ÖRNEK

			// Entitites.UrunParca urunparca =context.urunparca.Find(2,8) Burada 2 ID kolonu bulunan tablodan direk olarak veriyi çekebiliyoruz.
			#endregion

			#region Last
			//SORGUDAN GELEN EN SON VERİYİ GETİRİR.

			Entities.Urun urun15 = context.Urunler.Last();

			//URUNLER TABLOSUNDAN EN SON VERİYE DENK GELEN VERİYİ GETİRİR.


			#endregion



			#endregion
		}
	}
}