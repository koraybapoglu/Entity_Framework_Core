using Microsoft.EntityFrameworkCore;

namespace Entity_VeriGetirme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ETicaretDbContext context = new();
			#region Method(LINQ) Syntax

			var urunler = context.Urunler.ToList();
			var parcalar = context.Parcalar.ToList();

			#endregion

			#region Query(LINQ) Syntax

			var urunler2 = (from urun in context.Urunler select urun).ToList();
			var parcalar2 = (from parca in context.Parcalar select parca).ToList();

			#endregion

			#region IQueryable ve IEnumerable Nedir ?

			//IQueryable => Bir LINQ QUERY'SİNİN VEYA METHODUNUN DAHA EXECUTE EDİLMEMİŞ HALİDİR.

			//IEnumerable =>BİR LINQ QUERY'SİNİN VEYA METHODUNUN EXECUTE EDİLMİŞ HALİDİR.IN MEMORY KISMINDA ENTİTY'LERİN TUTULDUĞUNU BELİRTİR.
			var urunler3 = from urun in context.Urunler
						   select urun;
			//YUKARIDAKİ SORGU BİR IQueryable bir sorgudur.
			//urunler3 üzerinde gelince IQueryable olduğunu anlıyoruz.
			var urunler4 = (from urun in context.Urunler
							select urun).ToList();
			//YUKARIDAKİ SORGU BİR IEnumerable bir sorgudur.
			//Execute edilmiştir.

			#endregion

			#region Sorguyu Execute Etmek

			#region ToList

			var urunler5 = context.Urunler.ToList();
			var urunler6 = (from urun in context.Urunler
							select urun).ToList();
			#endregion

			#region Foreach

			var urunler7 = (from urun in context.Urunler
							select urun);
			foreach (Entities.Urun urun in urunler7)
			{
				Console.WriteLine(urun.UrunID);
				Console.WriteLine(urun.UrunAdi);
				Console.WriteLine(urun.Fiyat);
			}

			#endregion

			#region Deffered Execution(Ertelenmiş Çalışma) Nedir ?

			//Deffered Execution Foreach Döngüsü ile Execute ettiğimiz zamanlarda geçerli olan bir çalıştırmadır.
			int urunid = 5;

			var urunler8 = from urun in context.Urunler
						   where urun.UrunID > urunid
						   select urun;
			//IQueryable türünden bir Query gerçekleştirdik.
			urunid = 200;
			//Belirli Query'yi ilgilendiren değişkenin değerini değiştirdik.
			foreach (Entities.Urun urun in urunler8)
			{
				Console.WriteLine(urun.UrunID);
				Console.WriteLine(urun.UrunAdi);
				Console.WriteLine(urun.Fiyat);
			}
			//Normalde Id'si 5 ten büyük olan verileri getirmesi gerekirken,
			//Burada 200'den büyük verileri getirdi çünkü sorgu ilk başta execute edilmedi.
			//foreach döngüsünde execute edilip IEnumerable olduğu için sorgu son olan veriyi yani 200 değerini alarak query execute edilmiş oldu.

			//Bunada Defferede Execution Deniliyor.

			#endregion

			#endregion
		}
	}
}