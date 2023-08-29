using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Entity_VeriGetirme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ETicaretDbContext context = new();
			#region Çoğul Veri Getiren Sorgulama Fonksiyonları

			#region ToListAsync
			//--------------------------------------------
			#region Method Syntax

			var urunler = context.Urunler.ToList();

			#endregion
			//--------------------------------------------
			#region Query Syntax

			var urunler2 = (from urun in context.Urunler
							select urun).ToList();

			#endregion
			//--------------------------------------------
			#endregion

			#region Where
			//--------------------------------------------
			#region Method Syntax
			var urunler3 = context.Urunler.Where(u => u.UrunID > 0 && u.UrunAdi != null).ToList();
			#endregion
			//--------------------------------------------
			#region Query Syntax
			var urunler4 = (from urun in context.Urunler
							where urun.UrunID > 0 || urun.UrunAdi != null
							select urunler).ToList();
			#endregion
			//--------------------------------------------
			#endregion

			#region OrderBy
			//Sorgu Üzerinde Sıralama Yapmamızı sağlayan bir fonksiyondur.

			#region Method Syntax
			//--------------------------------------------
			var urunler5 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("a")).OrderBy(u => u.UrunID).ToList();
			//--------------------------------------------
			#endregion

			#region Query Syntax
			//--------------------------------------------
			var urunler6 = (from urun in context.Urunler
							where urun.UrunID > 0 || urun.UrunAdi.StartsWith("a")
							orderby urun.UrunAdi
							select urun).ToList();

			//--------------------------------------------
			#endregion

			#endregion

			#region ThenBy
			//--------------------------------------------
			var urunler7 = (from urun in context.Urunler
							where urun.UrunID > 0 || urun.UrunAdi.StartsWith("a")
							orderby urun.UrunAdi
							select urun)
			   .ThenBy(urun => urun.Fiyat)
			   .ThenBy(urun => urun.UrunID)
			   .ToList();
			//--------------------------------------------
			#endregion
			// !!!!!!!!!!!!!!!!!!! DESCENDİNG => SONDAN BAŞA DOĞRU || ASCENDİNG =>BAŞTAN SONA DOĞRU. !!!!!!!!!!!!!!!!!!!!!!!!
			#region OrderByDescending
			//--------------------------------------------
			//Descending Olarak Sıralama Yapmamızı Sağlar.

			#region Method Syntax
			//--------------------------------------------
			var urunler8 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("k")).OrderByDescending(u => u.UrunID).ToList();
			//--------------------------------------------
			#endregion

			#region Query Syntax
			//--------------------------------------------
			var urunler9 = (from urun in context.Urunler
							where urun.UrunID > 0 || urun.UrunAdi.StartsWith("k")
							orderby urun.UrunAdi descending
							select urun).ToList();
			//--------------------------------------------
			#endregion

			#endregion

			#region ThenByDescending
			//Descending Olarak Sıralama Yapmamızı Sağlar.
			#region Method Syntax
			//--------------------------------------------
			var urunler10 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("k")).OrderBy(u => u.UrunAdi).ThenByDescending(u => u.UrunID).ThenByDescending(u => u.Fiyat).ToList();
			//--------------------------------------------
			#endregion

			#region Query Syntax
			//--------------------------------------------
			var urunler11 = (from urun in context.Urunler
							 where urun.UrunID > 0 || urun.UrunAdi.StartsWith("k")
							 orderby urun.UrunID
							 select urun).ThenByDescending(urun => urun.UrunID).ThenByDescending(urun => urun.UrunAdi).ThenByDescending(urun => urun.Fiyat).ToList();
			//--------------------------------------------
			#endregion

			#endregion

			#endregion
		}
	}
}