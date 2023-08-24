using Microsoft.EntityFrameworkCore;
using Entity_CRUD_Islemleri.Entity;

namespace Entity_CRUD_Islemleri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SchoolDbContext context = new();
			bool isRunning = true;
			while (isRunning)
			{
				Console.Clear();
				Console.WriteLine("1 - Öğrenci Ekleme");
				Console.WriteLine("2 - Öğrenci Güncelleme");
				Console.WriteLine("3 - Öğrenci Listeleme");
				Console.WriteLine("4 - Öğrenci Çıkarma");
				Console.WriteLine("5 - Bölüm Ekleme");
				Console.WriteLine("6 - Bölüm Güncelleme");
				Console.WriteLine("7 - Bölüm Listeleme");
				Console.WriteLine("8 - Bölüm Çıkarma");
				Console.WriteLine("9 - Çıkış");
				Console.Write("Seçiminizi yapın: ");
				int choice = Convert.ToInt32(Console.ReadLine());


				switch (choice)
				{
					//ÖĞRENCİ EKLEME İŞLEMİ
					case 1:
						Student student = new Student();

						Console.Write("Lütfen Eklemek İstediğiniz Öğrenci Adını Giriniz: ");
						student.FirstName = Console.ReadLine();

						Console.Write("Lütfen " + $"{student.FirstName}" + " Adlı Öğrencinin Soyadını Giriniz: ");
						student.LastName = Console.ReadLine();

						Console.Write("Lütfen " + $"{student.FirstName}" + " Adlı Öğrencinin Yaşını Giriniz: ");
						student.Age = Convert.ToInt32(Console.ReadLine());

						context.Students.Add(student);
						context.SaveChanges();
						Console.WriteLine($"{student.FirstName}" + " Adlı " + $"{student.LastName}" + " Soyadlı Öğrenci Başarıyla Veritabanına Eklendi !");
						Console.ReadLine();
						break;
					//ÖĞRENCİ GÜNCELLEME İŞLEMİ
					case 2:
						Console.WriteLine("Güncelleme Yapmak İstediğiniz Öğrencinin Adını Giriniz:");
						string arananögradi = Console.ReadLine();
						Console.WriteLine("Güncelleme Yapmak İstediğiniz Öğrencinin Soyadını Giriniz:");
						string arananögrsoyadi = Console.ReadLine();
						var guncellenecekOgrenci = context.Students.FirstOrDefault(student => student.FirstName == arananögradi && student.LastName == arananögrsoyadi);

						if (guncellenecekOgrenci != null)
						{
							Console.WriteLine($"{guncellenecekOgrenci.FirstName} Adlı" + $"{guncellenecekOgrenci.LastName}"
							+ " Soyadlı Öğrencinin Adı Ne Olsun ?");
							guncellenecekOgrenci.FirstName = Console.ReadLine();

							Console.WriteLine($"{guncellenecekOgrenci.FirstName} Adlı Öğrencinin Soyadı Ne Olsun ?");
							guncellenecekOgrenci.LastName = Console.ReadLine();

							Console.WriteLine($"{guncellenecekOgrenci.FirstName} Adlı Öğrencin Yaşı Ne Olsun ?");
							guncellenecekOgrenci.Age = int.Parse(Console.ReadLine());

							context.SaveChanges();
							Console.WriteLine("Başarılı Bir Şekilde Güncelleme Yapılmıştır !");
							Console.ReadLine();
						}
						else
						{
							Console.WriteLine("Öğrenci bulunamadı.");
							Console.ReadLine();
						}
						break;
					//ÖĞRENCİ LİSTELEME İŞLEMİ
					case 3:
						Console.WriteLine("Öğrenciler Listeleniyor...");
						Console.WriteLine();
						var ögrenciler = context.Students.ToList();
						foreach (var item in ögrenciler)
						{
							Console.WriteLine("Öğrenci Adı:" + $"{item.FirstName}");
							Console.WriteLine("Öğrenci Soyadı:" + $"{item.LastName}");
							Console.WriteLine("Öğrenci Yaşı:" + $"{item.Age}");
							Console.WriteLine();
							Console.WriteLine("--------------------------------------");
						}
						Console.ReadLine();
						break;
					//ÖĞRENCİ ÇIKARMA İŞLEMİ
					case 4:

						Console.WriteLine("Çıkarılacak Öğrencinin Adını Giriniz:");
						string cikarilacakögrenciadi = Console.ReadLine();
						Console.WriteLine("Çıkarılacak Öğrencinin Soyadını Giriniz:");
						string cikarilacakögrencisoyadi = Console.ReadLine();
						var cikarilacakögrenci = context.Students.FirstOrDefault(u => u.FirstName == cikarilacakögrenciadi && u.LastName == cikarilacakögrencisoyadi);
						if (cikarilacakögrenci != null)
						{
							context.Students.Remove(cikarilacakögrenci);
							context.SaveChanges();
							Console.WriteLine("Başarılı Bir Şekilde " + $"{cikarilacakögrenci.FirstName}" + $" {cikarilacakögrenci.LastName}" + " Adlı Öğrenci Sistemden Silindi !");
							Console.ReadLine();
						}
						else
						{
							Console.WriteLine("Aranan Kayıt Bulunamadı Tekrar Deneyiniz !");
							Console.ReadLine();
						}
						break;
					//BÖLÜM EKLEME İŞLEMİ
					case 5:
						Console.WriteLine("Bölüm Adı Giriniz:");
						Course bolumekle = new()
						{
							Title = Console.ReadLine()
						};
						context.Courses.Add(bolumekle);
						context.SaveChanges();
						Console.WriteLine($"{bolumekle.Title}" + " Adlı Bölüm Başarıyla Eklendi !");
						Console.ReadLine();

						break;
					//BÖLÜM GÜNCELLEME İŞLEMİ
					case 6:
						Console.WriteLine("Güncelleme Yapmak istediğiniz Bölümün Adını Giriniz:");
						var guncellenecekbolum = context.Courses.FirstOrDefault(u => u.Title == Console.ReadLine());
						if (guncellenecekbolum != null)
						{
							Console.WriteLine($"{guncellenecekbolum.Title}" + " Adlı Bölümün Yeni Adı Ne Olsun ?");
							guncellenecekbolum.Title = Console.ReadLine();
							context.SaveChanges();
							Console.WriteLine("Bölüm Başarıyla Güncellendi !");
							Console.ReadLine();
						}
						break;
					//BÖLÜM LİSTELEME İŞLEMİ
					case 7:
						Console.WriteLine("BÖLÜMER LİSTELENİYOR...");
						Console.WriteLine("-----------------------------");
						var bolumler = context.Courses.ToList();
						foreach (var item in bolumler)
						{
							Console.WriteLine("--------------------");
							Console.WriteLine("Bölüm:" + item.Title);
							Console.WriteLine("--------------------");
							Console.WriteLine();
						}
						Console.ReadLine();
						break;
					//BÖLÜM ÇIKARMA İŞLEMİ
					case 8:
						
                        Console.WriteLine("Silmek istediğiniz Bölümün Adını Giriniz:");
						var silinecekbolum = context.Courses.FirstOrDefault(j=>j.Title==Console.ReadLine().ToString());
						if (silinecekbolum!=null)
						{
							context.Courses.Remove(silinecekbolum);
							context.SaveChanges();
							Console.WriteLine($"{silinecekbolum.Title}"+" Adlı Bölüm Başarıyla Silindi !");
							Console.ReadLine();
						}
						else 
						{
                            Console.WriteLine("Aranan Bölüm Bulunamadı Lütfen Tekrar Deneyiniz.");
							Console.ReadLine();
                        }
                        break;
					//ÇIKIŞ İŞLEMİ
					case 9:
						Console.WriteLine("Çıkış yapılıyor...");
						isRunning = false;
						Console.ReadLine();
						break;

					default:
						Console.WriteLine("Geçersiz seçim. Tekrar Deneyiniz.");
						Console.ReadLine();
						break;
				}
			}
		}
	}
}