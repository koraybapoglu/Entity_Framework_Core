# LINQ `Except` Operatörü Kullanımı

`Except`, LINQ (Language Integrated Query) kütüphanesinde bulunan ve iki koleksiyon arasındaki farkı bulmak için kullanılan bir operatördür. İlk koleksiyondaki öğelerden ikinci koleksiyonda bulunmayanları seçer. 

## Kullanım

Örnek bir kullanımı aşağıda gösterilmektedir:

```csharp
List<int> koleksiyon1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> koleksiyon2 = new List<int> { 3, 4, 5, 6, 7 };

var fark = koleksiyon1.Except(koleksiyon2);

foreach (var item in fark)
{
    Console.WriteLine(item); // Çıktı: 1, 2
}

Yukarıdaki örnekte, koleksiyon1 ve koleksiyon2 adlı iki koleksiyon bulunmaktadır. Except operatörü kullanılarak koleksiyon1 içinde bulunan ancak koleksiyon2 içinde bulunmayan öğeleri seçiyoruz. Sonuç olarak, fark adlı koleksiyon, 1 ve 2 değerlerini içermektedir, çünkü bu değerler koleksiyon1 içinde bulunup koleksiyon2 içinde bulunmamaktadır.
Kullanım Alanları

Except operatörü, iki koleksiyon arasındaki farkları veya eksik öğeleri bulma ihtiyacı olduğunuzda oldukça kullanışlıdır. Özellikle koleksiyonlar arasında karşılaştırma yaparken veya veri işleme işlemleri sırasında farklılık arayanlar için faydalıdır.
Kaynaklar

LINQ Except Method (Microsoft Docs)