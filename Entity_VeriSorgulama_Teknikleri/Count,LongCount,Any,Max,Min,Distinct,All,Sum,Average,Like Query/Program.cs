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
			#region Count
			//Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak (int) ile bizlere bildiren fonksiyondur.
			var urunler = context.Urunler.Count(u => u.Fiyat == 500);
			#endregion

			#region LongCount
			//Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak (long) ile bizlere bildiren fonksiyondur.
			var urunler2 = context.Urunler.LongCount(u => u.Fiyat == 500);
			#endregion

			#region Any

			//Sorgu neticesinde verinin gelip gelmediğini veren fonksiyondur.Boolean türünde değer döndürür.
			bool VarMi = context.Urunler.Any(u => u.UrunID == 1);

			#endregion

			#region Max
			//Oluşturulan sorguda verilen kolonda en yüksek olan değer hangisi ise onu getirir.

			var fiyat = context.Urunler.Max(u => u.Fiyat);

			#endregion

			#region Min
			//Oluşturulan sorguda verilen kolonda en düşük olan değer hangisi ise onu getirir.
			var fiyat2 = context.Urunler.Min(u => u.Fiyat);

			#endregion

			#region Distinct
			//Sorguda kendini tekrarlayan kayıtlar varsa bunları tekleştiren bir işleve sahiptir.

			var urunler3 = context.Urunler.Distinct().ToList();

			#endregion

			#region All
			//Bir sorgu neticesinde gelen verilerin, verilen şarta uyup uymadığını kontrol etmektedir. Eğer ki tüm veriler şarta uyuyorsa true, uymuyorsa false döndürecektir.
			var m = context.Urunler.All(u => u.UrunAdi != null && u.Fiyat != null);

			#endregion

			#region Sum
			//Oluşturulan sorguda verilen kolonda Toplamı veren sorgu tipidir.

			float fiyat3 = context.Urunler.Sum(u => u.Fiyat);

			#endregion

			#region Average
			//Vermiş olduğumuz sayısal propertynin aritmetik ortalamasını alır.

			var aritmetikortalama = context.Urunler.Average(u => u.Fiyat);

			#endregion

			#region Contains
			//LİKE '%.....%' sorgusu oluşturmamızı sağlar.

			var urunler4 =context.Urunler.Where(u=>u.UrunAdi.Contains("7")).ToList();

			#endregion

			#region StartsWith
			//LİKE '....%' sorgusu oluşturmamızı sağlar.

			var urunler5 = await context.Urunler.Where(u => u.UrunAdi.StartsWith('U')).ToListAsync();
			#endregion

			#region EndWith
			//LİKE '%...' sorgusu oluşturmamızı sağlar.

			var urunler6 = await context.Urunler.Where(u => u.UrunAdi.EndsWith("K")).ToListAsync();
			#endregion
		}
	}
}