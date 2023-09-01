# LINQ Sorgu Fonksiyonları Örnekleri (Devam)

## GroupBy ve Foreach Fonksiyonları

Bu bölümde LINQ sorgularını kullanarak gruplama yapmayı ve sonuçları döngülerle işlemeyi gösteren örnekler bulacaksınız.

### GroupBy Fonksiyonu

`GroupBy`, verileri belirli bir kritere göre gruplamak için kullanılır.

#### Method Syntax

```csharp
var datas = await context.Urunler.GroupBy(u => u.Fiyat).Select(group => new
{
    Count = group.Count(),
    Fiyat = group.Key
}).ToListAsync(); 


Query Syntax

var datas2 = await (from urun in context.Urunler
                    group urun by urun.Fiyat into g
                    select new
                    {
                        Count = g.Count(),
                        Fiyat = g.Key
                    }).ToListAsync();

Foreach Fonksiyonu

Foreach, bir sorgu fonksiyonu değil, sorgu sonuçlarını işlemek için kullanılır. Sonuçlar üzerinde döngü oluşturmanızı ve verilere tek tek erişmenizi sağlar. Bu, foreach döngüsünün bir metodu olarak düşünülebilir.

Örnek:

foreach (var item in datas)
{
    Console.WriteLine(item.Fiyat);
    Console.WriteLine(item.Count);
}

// Ya da

datas.ForEach(x =>
{
    // İşlemler burada yapılır
});

