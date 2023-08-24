using Microsoft.EntityFrameworkCore;

namespace Entity_Veri_Silme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//DELETE İŞLEMİ
			UrunlerDbContext context = new();
			var silinecekurun = context.Urunler.FirstOrDefault(u => u.UrunId == 1);
			context.Urunler.Remove(silinecekurun);
			context.SaveChanges();
			Console.WriteLine("Ürün Başarıyla Silindi !");
			//NESNE ÜZERİNDEN TAKİBİ SAĞLANAMAYAN VERİ SİLME İŞLEMİ
			Urun urun = new()
			{
				UrunAdi = "A ürün",
				UrunFiyat = 2000
			};
			context.Urunler.Remove(urun);
			context.SaveChanges();
			//STATE İLE SİLME İŞLEMİ
			Urun urun2 = new()
			{
				UrunId = 2
			};
			context.Entry(urun2).State = EntityState.Deleted;
			context.SaveChanges();
			//REMOVE RANGE İŞLEMİ
			List<Urun> Urunler = context.Urunler.Where(j=>j.UrunId>=1 && j.UrunId<=4).ToList();
			context.Urunler.RemoveRange(Urunler);
			context.SaveChanges();
		}
	}
	class UrunlerDbContext : DbContext
	{
		public DbSet<Urun> Urunler { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=Urun;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
	class Urun
	{
		public int UrunId { get; set; }
		public string UrunAdi { get; set; }
		public int UrunFiyat { get; set; }
	}
}