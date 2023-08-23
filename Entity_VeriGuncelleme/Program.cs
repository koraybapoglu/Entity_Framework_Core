using Microsoft.EntityFrameworkCore;

namespace Entity_VeriGuncelleme
{
	class UyelerDbContext : DbContext
	{
		public DbSet<Uye> Uyeler { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=Uyeler2;Trusted_Connection=True;TrustServerCertificate=true;");
		}
	}
	class Uye
	{
		public int UyeID { get; set; }
		public string UyeAdi { get; set; }
		public string UyeSoyadi { get; set; }
		public int UyeYasi { get; set; }
		public string UyeCinsiyet { get; set; }
	}
	internal class Program
	{
		public static UyelerDbContext context = new();
		static void Main(string[] args)
		{
			#region VeriGüncelleme
			
			VeriEkle(); //Örnek Veriler Getirtiyoruz.
			Uye Uye = context.Uyeler.FirstOrDefault(u => u.UyeAdi == "Koray"); //Burada Hangi Verinin Güncelleneceğini seçiyoruz.
			Uye.UyeAdi = "Koray2"; //Güncellenecek nesnenin kolonlarına yeri verilen giriyoruz
			Uye.UyeSoyadi = "Bapoğlu2"; //Güncellenecek nesnenin kolonlarına yeri verilen giriyoruz
			Uye.UyeCinsiyet = "Erkek2"; //Güncellenecek nesnenin kolonlarına yeri verilen giriyoruz
			Uye.UyeYasi = 22; //Güncellenecek nesnenin kolonlarına yeri verilen giriyoruz
			context.SaveChanges(); //Güncellenecek neseneyi execute ediyoruz.
			Console.WriteLine("Veri Başarıyla Güncellendi !");
			Console.WriteLine("GUNCEL UYE ADI=" + Uye.UyeAdi);
			Console.WriteLine("GUNCEL UYE SOYADI=" + Uye.UyeSoyadi);
			Console.WriteLine("GUNCEL UYE CINSIYET=" + Uye.UyeCinsiyet);
			Console.WriteLine("GUNCEL UYE YASI=" + Uye.UyeYasi);
			Console.ReadLine();
			/*
			 Veri Başarıyla Güncellendi !
			          GUNCEL UYE ADI=Koray2
			          GUNCEL UYE SOYADI=Bapoğlu2
			          GUNCEL UYE CINSIYET=Erkek2
			          GUNCEL UYE YASI=22
			 */
			#endregion


			#region SabitVeriyiGuncelle
			
			VeriEkle();
			Uye guncellenecekuye = new();
			guncellenecekuye.UyeID = 34;
			guncellenecekuye.UyeAdi = "Ahmet";
			guncellenecekuye.UyeSoyadi = "AhmetSoyadi";
			guncellenecekuye.UyeYasi = 45;
			guncellenecekuye.UyeCinsiyet = "Erkek2";
			context.Uyeler.Update(guncellenecekuye);
			context.SaveChanges();
			Console.WriteLine("Veri Başarıyla Güncellendi !");
			Console.WriteLine("GUNCEL UYE ADI=" + guncellenecekuye.UyeAdi);
			Console.WriteLine("GUNCEL UYE SOYADI=" + guncellenecekuye.UyeSoyadi);
			Console.WriteLine("GUNCEL UYE CINSIYET=" + guncellenecekuye.UyeCinsiyet);
			Console.WriteLine("GUNCEL UYE YASI=" + guncellenecekuye.UyeYasi);
			Console.ReadLine();
			/*
			 Veri Başarıyla Güncellendi !
             GUNCEL UYE ADI=Ahmet
             GUNCEL UYE SOYADI=AhmetSoyadi
             GUNCEL UYE CINSIYET=Erkek2
             GUNCEL UYE YASI=45
			 */

			#endregion


			#region EntityState
			
			Uye uye = context.Uyeler.FirstOrDefault(u => u.UyeID == 34);
			Console.WriteLine(context.Entry(uye).State);  //UNCHANGED => HİÇBİR İŞLEM YOK
			uye.UyeAdi = "Hilmi";
			Console.WriteLine(context.Entry(uye).State); //MODİFİED => VERİ ÜZERİNDE GÜNCELLEME OLUŞTU
			context.SaveChanges(); //BURADA EXECUTE ETTİKTEN SONRA VERİDE HİÇBİR İŞLEM OLUŞMADIĞI İÇİN AŞŞAĞIDAKİ STATE UNCHANGED OLARAK ÇIKACAKTIR.
			Console.WriteLine(context.Entry(uye).State); //HİÇBİR İŞLEM YOK
			Console.ReadLine();
			/*
			 Unchanged
             Modified
             Unchanged
			  */
			#endregion


			#region BirdenFazlaVeriGuncelleme
			VeriEkle();
			Console.WriteLine("ÜYELER BAŞARIYLA GETİRİLDİ !");
			Console.WriteLine("---------------------------------");
			Console.WriteLine();
			var uyeler = context.Uyeler.ToList();
			foreach (var item in uyeler)
			{
				item.UyeAdi += "..";
			}
			context.SaveChanges();
			Console.WriteLine("ÜYELER BAŞARIYLA GÜNCELLENDİ");
			Console.WriteLine("----------------------------------");
			Console.WriteLine();
			var gunceluyeler = context.Uyeler.ToList();
			foreach (var item2 in gunceluyeler)
			{
				Console.WriteLine("UYE ADI => " + item2.UyeAdi);
				Console.WriteLine("UYE SOYADI => " + item2.UyeSoyadi);
				Console.WriteLine("UYE YASI => " + item2.UyeYasi);
				Console.WriteLine("UYE CINSIYETI => " + item2.UyeCinsiyet);
				Console.WriteLine("************************");
			}
			Console.ReadLine();
			/*
			 ÜYELER BAŞARIYLA GETİRİLDİ !
             ---------------------------------

             ÜYELER BAŞARIYLA GÜNCELLENDİ
             ----------------------------------

             UYE ADI => Koray..
             UYE SOYADI => Bapoğlu
             UYE YASI => 22
             UYE CINSIYETI => Erkek
			 ************************
             UYE ADI => Ahmet..
             UYE SOYADI => Taş
             UYE YASI => 33
             UYE CINSIYETI => Erkek
			 ************************
             UYE ADI => Deniz..
             UYE SOYADI => Kalkan 
             UYE YASI => 25
             UYE CINSIYETI => Kadın
			 ************************
             UYE ADI => Merve..
             UYE SOYADI => Taş
             UYE YASI => 28
             UYE CINSIYETI => Kadın
			 ************************
             UYE ADI => Mehmet..
             UYE SOYADI => Kılıç
             UYE YASI => 27
             UYE CINSIYETI => Erkek
			 ************************
			 */
			#endregion


		}
		#region EklenecekOrnekVeri
		public static void VeriEkle()
		{
			Uye uye1 = new()
			{
				UyeAdi = "Koray",
				UyeSoyadi = "Bapoğlu",
				UyeYasi = 22,
				UyeCinsiyet = "Erkek"
			};
			Uye uye2 = new()
			{
				UyeAdi = "Ahmet",
				UyeSoyadi = "Taş",
				UyeYasi = 33,
				UyeCinsiyet = "Erkek"
			};
			Uye uye3 = new()
			{
				UyeAdi = "Deniz",
				UyeSoyadi = "Kalkan",
				UyeYasi = 25,
				UyeCinsiyet = "Kadın"
			};
			Uye uye4 = new()
			{
				UyeAdi = "Merve",
				UyeSoyadi = "Taş",
				UyeYasi = 28,
				UyeCinsiyet = "Kadın"

			};
			Uye uye5 = new()
			{
				UyeAdi = "Mehmet",
				UyeSoyadi = "Kılıç",
				UyeYasi = 27,
				UyeCinsiyet = "Erkek"
			};
			context.Uyeler.AddRange(uye1, uye2, uye3, uye4, uye5);
			context.SaveChanges();
		}
		#endregion
	}

}