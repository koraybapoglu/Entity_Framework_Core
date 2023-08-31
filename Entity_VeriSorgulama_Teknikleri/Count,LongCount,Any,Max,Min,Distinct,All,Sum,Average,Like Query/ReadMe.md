# LINQ Sorgu Fonksiyonları Örnekleri

Bu proje, Entity Framework Core kullanarak çeşitli LINQ sorgu fonksiyonlarını içeren bir örnek uygulamadır.

## Proje Açıklaması

Bu proje, Entity Framework Core kullanarak Count, LongCount, Any, Max, Min, Distinct, All, Sum, Average, Contains, StartsWith ve EndsWith gibi LINQ sorgu fonksiyonlarını içermektedir.

## Proje Dosyaları

- `Program.cs`: LINQ sorgu fonksiyonlarının kullanıldığı ana program dosyası.
- `ETicaretDbContext.cs`: Veritabanı bağlantısı ve DbSet tanımlamalarını içeren DbContext sınıfı.

## LINQ Sorgu Fonksiyonları

### Count

Oluşturulan sorgunun execute edilmesi neticesinde belirtilen koşulu sağlayan verilerin sayısını döndüren fonksiyondur.

```csharp
var urunler = context.Urunler.Count(u => u.Fiyat == 500);

LongCount

Oluşturulan sorgunun execute edilmesi neticesinde belirtilen koşulu sağlayan verilerin sayısını (long) olarak döndüren fonksiyondur.

csharp

var urunler2 = context.Urunler.LongCount(u => u.Fiyat == 500);

Any

Sorgu neticesinde verinin gelip gelmediğini belirten fonksiyondur. Boolean türünde değer döndürür.

csharp

bool VarMi = context.Urunler.Any(u => u.UrunID == 1);

Max

Oluşturulan sorguda belirtilen kolonda en yüksek değeri getiren fonksiyondur.

csharp

var fiyat = context.Urunler.Max(u => u.Fiyat);

Min

Oluşturulan sorguda belirtilen kolonda en düşük değeri getiren fonksiyondur.

csharp

var fiyat2 = context.Urunler.Min(u => u.Fiyat);

Distinct

Sorguda kendini tekrarlayan kayıtları tekleştirir.

csharp

var urunler3 = context.Urunler.Distinct().ToList();

All

Sorgu sonucu gelen verilerin belirtilen şartı sağlayıp sağlamadığını kontrol eder.

csharp

var m = context.Urunler.All(u => u.UrunAdi != null && u.Fiyat != null);

Sum

Oluşturulan sorguda belirtilen kolonun değerlerinin toplamını getiren fonksiyondur.

csharp

float fiyat3 = context.Urunler.Sum(u => u.Fiyat);

Average

Oluşturulan sorguda belirtilen sayısal özelliğin aritmetik ortalamasını hesaplar.

csharp

var aritmetikortalama = context.Urunler.Average(u => u.Fiyat);

Contains

LİKE '%...%' sorgusuna karşılık gelir.

csharp

var urunler4 = context.Urunler.Where(u => u.UrunAdi.Contains("7")).ToList();

StartsWith

LİKE '...%' sorgusuna karşılık gelir.

csharp

var urunler5 = await context.Urunler.Where(u => u.UrunAdi.StartsWith('U')).ToListAsync();

EndsWith

LİKE '%...' sorgusuna karşılık gelir.

csharp

var urunler6 = await context.Urunler.Where(u => u.UrunAdi.EndsW