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

			#region GroupBy Fonksiyonu
			//Gruplama yapmamızı sağlayan fonksiyondur.

			#region Method Syntax
			var datas = await context.Urunler.GroupBy(u => u.Fiyat).Select(group => new
			{
				Count = group.Count(),
				Fiyat = group.Key
			}).ToListAsync();
			#endregion

			#region Query Syntax
			var datas2 = await (from urun in context.Urunler
								group urun by urun.Fiyat
								into g
								select new
								{
									Count = g.Count(),
									Fiyat = g.Key
								}).ToListAsync();
			#endregion

			#endregion

			#region Foreach Fonksiyonu
			//Bir sorgulama fonksiyonu değildir.
			//Sorgulama neticesinde elde edilen veriler üzerinde dönmemizi ve teker teker verileri elde edip işlemler yapabilmemizi sağlayan bir fonksiyondur. foreach döngüsünün metot halidir.

			foreach (var item in datas)
			{
				Console.WriteLine(item.Fiyat);
				Console.WriteLine(item.Count);
			}
			datas.ForEach(x =>
			{


			});
            #endregion
        }
	}
}