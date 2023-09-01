# LI# LINQ Sorgu Fonksiyonları Örnekleri (Devam)

## Sorgu Sonucu Dönüşüm Fonksiyonları

Bu bölümde LINQ sorgu sonuçlarını farklı veri türlerine dönüştürmek için kullanılan bazı önemli fonksiyonları bulacaksınız.

### ToDictionary

Sorgu sonucundaki verileri bir sözlük (dictionary) olarak elde etmek veya saklamak için kullanılır.

```csharp
var urunler = await context.Urunler.ToDictionaryAsync(u => u.UrunAdi, u => u.Fiyat);
NQ Sorgu Fonksiyonları Örnekleri (Devam)

## Sorgu Sonucu Dönüşüm Fonksiyonları

Bu bölümde LINQ sorgu sonuçlarını farklı veri türlerine dönüştürmek için kullanılan bazı önemli fonksiyonları bulacaksınız.

### ToDictionary

Sorgu sonucundaki verileri bir sözlük (dictionary) olarak elde etmek veya saklamak için kullanılır.

```csharp
var urunler = await context.Urunler.ToDictionaryAsync(u => u.UrunAdi, u => u.Fiyat);

ToArray

Sorgu sonucundaki verileri bir dizi olarak elde etmek için kullanılır.

    var urunler2 = await context.Urunler.ToArrayAsync();

Select

Select fonksiyonu, sorgu sonucundan belirli kolonları veya özellikleri seçmek için kullanılır.
    
    var urunler3 = await context.Urunler.Select(u => new Urun
    {
      UrunID = u.UrunID,
    Fiyat = u.Fiyat
    }).ToListAsync();

SelectMany

SelectMany, ilişkisel tablolardan veri çekmek ve sonuçları düzleştirmek için kullanılır.
    
    var urunler5 = context.Urunler
    .Include(u => u.Parcalar)
    .SelectMany(u => u.Parcalar, (u, p) => new
    {
        u.UrunID,
        u.Fiyat,
        p.ParcaID
    }).ToList();

