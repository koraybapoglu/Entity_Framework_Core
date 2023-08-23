using Microsoft.EntityFrameworkCore;

namespace Entity_CodeFirst
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
	class KutuphaneDbContext : DbContext
	{
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
		public DbSet<Kategori> Kategoriler { get; set; }
		public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=Kutuphane;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
	class Yazar
	{
		public int YazarID { get; set; }
		public string YazarAdi { get; set; }
		public string YazarSoyadi { get; set; }
		public DateTime YazarDogumTarihi { get; set; }
	}
	class Kitap
	{
		public int KitapID { get; set; }
		public string KitapBaslik { get; set; }
		public DateTime KitapYayinTarihi { get; set; }

	}
	class Musteri
	{
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriEposta { get; set; }
    }
	class Kategori
	{
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
    }
	class YayinEvi 
	{
        public int YayinEviID { get; set; }
        public string YayinEviAdi { get; set; }
        public DateTime KurulusTarihi { get; set; }
    }
	class Yorum
	{
        public int YorumID { get; set; }
        public int KitapID { get; set; }
        public int MusteriID { get; set; }
        public string YorumMetni { get; set; }
        public DateTime YorumTarihi { get; set; }
    }
}