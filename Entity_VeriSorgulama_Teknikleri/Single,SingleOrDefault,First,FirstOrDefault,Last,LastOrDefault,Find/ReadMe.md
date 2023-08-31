# LINQ Sorguları Örnekleri

Bu proje, Entity Framework Core kullanarak tekil veri getirme sorgularını içeren bir örnek uygulamadır.

## Proje Açıklaması

Bu proje, Entity Framework Core kullanarak tekil veri getirme sorgularını içeren örnekleri içermektedir.

## Proje Dosyaları

- `Program.cs`: Tekil veri getirme sorgularının kullanıldığı ana program dosyası.
- `ETicaretDbContext.cs`: Veritabanı bağlantısı ve DbSet tanımlamalarını içeren DbContext sınıfı.

## Tekil Veri Getiren Sorgulama Fonksiyonları

### Single

Sorgu çalıştığında tek bir verinin gelmesi amaçlandığında kullanılır. Birden fazla veri veya hiç veri gelmesi durumunda hata fırlatır.

var urun = context.Urunler.Single(u => u.UrunID == 61);


### SingleOrDefault

Sorgu çalıştığında tek bir verinin gelmesi amaçlandığında kullanılır. Birden fazla veri gelirse hata fırlatmaz, null döner.

var urun4 = context.Urunler.SingleOrDefault(u => u.UrunID == 61);


### First

Sorgu neticesinde elde edilen verilerden ilkini getirir. Hiç veri gelmezse hata fırlatır.

var urun7 = context.Urunler.First(u => u.UrunID == 61);


### FirstOrDefault

Sorgu neticesinde elde edilen verilerden ilkini getirir. Hiç veri gelmezse null döner.

var urun10 = context.Urunler.FirstOrDefault(u => u.UrunID == 61);


### Find

ID (Primary Key) üzerinden tekil sorgular yapmak için kullanılır.

Entities.Urun urun13 = context.Urunler.Find(55);


### Last

Sorgudan gelen en son veriyi getirir.

Entities.Urun urun15 = context.Urunler.Last();


## Migration (Adım Adım)

1. Projenin ana klasöründe terminali açın.
2. `dotnet ef migrations add Initial` komutunu kullanarak ilk migrasyon adımını oluşturun.
3. `dotnet ef database update` komutunu kullanarak veritabanını güncelleyin.

Bu adımlar, Entity Framework Core Migration kullanarak veritabanınızı oluşturmanıza ve güncellemenize yardımcı olacaktır.

## Lisans

Bu proje ücretsiz bir şekilde kullanıma sunulmuştur.








