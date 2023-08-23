using Microsoft.EntityFrameworkCore;

namespace Entity_VeriEkleme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region TekliVeriEkleme

			UyelerDbContext context = new(); //Veri Eklemek için ilk olarak context nesnesi üretiyoruz.

			Uye uye1 = new Uye() //Ardından hangi entity class'ına veri eklemek istiyorsak ondan nesne üretiyoruz.
			{
				UyeAdi = "Koray",
				UyeSoyadi = "Bapoğlu",
				UyeCinsiyeti = "Erkek" //Veri Girişlerini Yapıyoruz.
			};
			context.Uyeler.Add(uye1); //Ekleme Methodunu Çalıştırıyoruz.
			context.SaveChanges(); //Eklenen Verileri Execute Etmesini Söylüyoruz.(Bu işlem Sadece Veritabanında bulunan INSERT,DELETE,UPDATE işlemlerinde geçerlidir)
			#endregion
			#region ÇokluVeriEkleme
			Uye uye2 = new Uye() //Entity class'ından nesne üretiyoruz.
			{
				UyeAdi = "Deneme1",
				UyeSoyadi = "DenemeSoyadi",
				UyeCinsiyeti = "Bilinmeyen"
			};
			Uye uye3 = new Uye() //Entity class'ından nesne üretiyoruz.
			{
				UyeAdi = "Deneme2",
				UyeSoyadi = "DenemeSoyadi2",
				UyeCinsiyeti = "DenemeCinsiyet"
			};
			context.Uyeler.AddRange(uye2, uye3); //Toplu bir şekilde veri ekleme methodunu çağırıyoruz.
			context.SaveChanges(); //Execute Ediyoruz.
			#endregion
			#region EklenenVeriniID'siniGetirmeİslemi
			Uye uye4 = new Uye()
			{
				UyeAdi = "EklenenVeri1",
				UyeSoyadi = "EklenenVeriSoyadi1",
				UyeCinsiyeti = "EklenenVeriCinsiyeti1"
			};
			context.Uyeler.Add(uye4);
			context.SaveChanges();
			Console.WriteLine(uye4.UyeID); //Bu şekilde Eklenen Verinin ID değerini alabiliyoruz.
			Console.WriteLine(uye4.UyeAdi);
			Console.WriteLine(uye4.UyeSoyadi);
            Console.WriteLine(uye4.UyeCinsiyeti);
			/*
			 4      => EklenenVerinin ID'si.
             EklenenVeri1
             EklenenVeriSoyadi1
             EklenenVeriCinsiyeti1
			 */
			#endregion

		}
	}
	class UyelerDbContext : DbContext
	{
		public DbSet<Uye> Uyeler { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=Uyeler;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
	class Uye
	{
		public int UyeID { get; set; }
		public string UyeAdi { get; set; }
		public string UyeSoyadi { get; set; }
		public string UyeCinsiyeti { get; set; }
	}
}