# LINQ Sorguları Örnekleri

Bu proje, LINQ sorgularını kullanarak verileri çekme ve sıralama işlemlerini gösteren bir örnek uygulamadır.

## Proje Açıklaması

Bu proje, Entity Framework Core kullanarak `Urun` ve `Parca` tablolarındaki verileri çekme ve sıralama işlemlerini içermektedir.

## Proje Dosyaları

- `Program.cs`: LINQ sorgularının kullanıldığı ana program dosyası.
- `ETicaretDbContext.cs`: Veritabanı bağlantısı ve DbSet tanımlamalarını içeren DbContext sınıfı.

## Çoğul Veri Getiren Sorgulama Fonksiyonları

### ToListAsync

```csharp
var urunler = context.Urunler.ToList();

Where

Method Syntax:

var urunler4 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("a"))
                              .OrderBy(u => u.UrunID)
                              .ToList()
Query Syntax:

var urunler5 = (from urun in context.Urunler
                where urun.UrunID > 0 || urun.UrunAdi.StartsWith("a")
                orderby urun.UrunAdi
                select urun)
                .ToList();
OrderBy

Method Syntax:

var urunler6 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("a"))
                              .OrderBy(u => u.UrunID)
                              .ToList();
Query Syntax:

var urunler7 = (from urun in context.Urunler
                where urun.UrunID > 0 || urun.UrunAdi.StartsWith("a")
                orderby urun.UrunAdi
                select urun)
                .ToList();

ThenBy

var urunler8 = (from urun in context.Urunler
                where urun.UrunID > 0 || urun.UrunAdi.StartsWith("a")
                orderby urun.UrunAdi
                select urun)
               .ThenBy(urun => urun.Fiyat)
               .ThenBy(urun => urun.UrunID)
               .ToList();

OrderByDescending

Method Syntax:

var urunler9 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("k"))
                              .OrderByDescending(u => u.UrunID)
                              .ToList();


Query Syntax:

var urunler10 = (from urun in context.Urunler
                 where urun.UrunID > 0 || urun.UrunAdi.StartsWith("k")
                 orderby urun.UrunAdi descending
                 select urun)
                 .ToList();


ThenByDescending

Method Syntax:

var urunler11 = context.Urunler.Where(u => u.UrunID > 0 || u.UrunAdi.StartsWith("k"))
                               .OrderBy(u => u.UrunAdi)
                               .ThenByDescending(u => u.UrunID)
                               .ThenByDescending(u => u.Fiyat)
                               .ToList();


Query Syntax:

var urunler12 = (from urun in context.Urunler
                 where urun.UrunID > 0 || urun.UrunAdi.StartsWith("k")
                 orderby urun.UrunID
                 select urun)
                 .ThenByDescending(urun => urun.UrunID)
                 .ThenByDescending(urun => urun.UrunAdi)
                 .ThenByDescending(urun => urun.Fiyat)
                 .ToList();
