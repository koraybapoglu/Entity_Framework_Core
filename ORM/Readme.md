# ORM (Object-Relational Mapping) Nedir?

## ORM Nedir?

ORM (Object-Relational Mapping), nesne tabanlı programlama ve ilişkisel veritabanları arasındaki veri iletişimini kolaylaştıran bir yazılım tasarım desenidir. ORM, nesne tabanlı programlama dillerinde (örneğin, C#, Java, Python) çalışan nesneleri ve veritabanı arasındaki veri dönüşümünü otomatikleştirir ve basitleştirir.

## ORM Açılımı

ORM, "Object-Relational Mapping" açılımının kısaltmasıdır. Her bir kelimenin açılımı şu şekildedir:
- **Object:** Nesne
- **Relational:** İlişkisel
- **Mapping:** Eşleştirme

## Entity Framework Core

Entity Framework Core, .NET platformu için bir ORM (Object-Relational Mapping) aracıdır. Bu araç, veritabanı işlemlerini nesne tabanlı bir şekilde yönetmenize olanak tanır. Entity Framework Core, .NET Core ve .NET 5+ sürümlerinde kullanılabilir.

## Entity Framework Core Kullanımı

Entity Framework Core kullanımı genellikle aşağıdaki adımları içerir:

1. **Veri Modeli Tanımlama:** Entity Framework Core, veritabanı tablolarını nesne sınıfları olarak tanımlamanıza olanak tanır. Örneğin, bir `Ogrenci` sınıfı, `Ogrenciler` tablosunu temsil edebilir.

2. **Veritabanı Bağlantısı Kurma:** Entity Framework Core, veritabanı ile iletişim kurmak için bir bağlantı sağlar. Bu bağlantı dizesi, projenizin yapılandırma dosyasında bulunabilir.

3. **CRUD İşlemleri:** Entity Framework Core, Create (Oluşturma), Read (Okuma), Update (Güncelleme) ve Delete (Silme) işlemlerini nesne yönelimli bir şekilde gerçekleştirmenize olanak tanır.

4. **LINQ Sorguları:** Entity Framework Core, LINQ (Language-Integrated Query) kullanarak veritabanı sorgularını nesne sınıfları üzerinden çalıştırmanıza olanak tanır.

## ASP.NET Core ve Entity Framework Core Kullanmanın Avantajları

ASP.NET Core ve Entity Framework Core kullanmanın bazı avantajları şunlardır:

- **Veri Modeli ile Uyumlu:** Entity Framework Core, veri modelini nesne olarak temsil eder, bu da veri modeli ile kodun daha iyi uyumlu olmasını sağlar.

- **Veritabanı Bağımsızlığı:** Veritabanı değişiklikleri kodu etkilemez, bu da veritabanı bağımsızlığını sağlar.

- **Hızlı Geliştirme:** Veritabanı işlemleri hızlı bir şekilde gerçekleştirilir, bu da geliştirme sürecini hızlandırır.

- **Kod Daha Azdır:** SQL sorgularını yazma ihtiyacını ortadan kaldırır, böylece daha az kod yazmanıza olanak tanır.

## Lisans

Bu README.md dosyası, ASP.NET Core ve Entity Framework Core konularını açıklamaktadır. Dosyanın içeriği üzerinde herhangi bir lisans kısıtlaması bulunmamaktadır. Özgürce kullanabilir ve özelleştirebilirsiniz.
