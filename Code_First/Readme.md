# CODE FIRST MIGRATION

## Migration Nedir?

**Migration**, kod tarafında oluşturduğumuz tabloları veritabanına uygun bir şekilde dönüştüren bir kavramdır.

## Migrate Etme Nedir?

**Migrate etmek**, oluşturduğumuz migration'ları veritabanına entegre etme işlemidir.

## Migration Oluşturmak İçin Neler Gereklidir?

- **DbContext Sınıfı**: Entity class'ları ve veritabanının nasıl oluşturulacağı gibi bilgileri içeren bir sınıftır.

## DbContext Sınıfı Nedir?

**DbContext sınıfı**, entity class'larını içinde barındırdığımız bir sınıftır. Hangi tabloların oluşturulacağını ve veritabanının nereye kaydedileceğini belirttiğimiz sınıftır.

## Entity Class'ları Nedir?

**Entity class'ları**, her bir tabloya karşılık gelen class'lardır. Örneğin, "Musteri" class'ı "Müşteriler" tablosunu temsil eder. Her bir property, bir tablonun kolonuna denk gelir.

## Migration Nasıl Oluşturulur?

1. Entity class'larını ve DbContext sınıfını düzgün bir şekilde tamamlayın.
2. Proje içerisine `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer`, `Microsoft.EntityFrameworkCore.Tools` paketlerini ekleyin.

## Migration Oluşturma Aşaması

1. Package Manager Console (PMC) kullanarak `Add-Migration Init` komutu ile migration oluşturabilirsiniz.
2. Her güncelleme sonrasında `Add-Migration` komutu ile migration oluşturmanız gerekmektedir.

## Migrate Etme İşlemi

- Veritabanını güncellemek için PMC'den `Update-Database` komutunu kullanabilirsiniz.
- Belirli bir migration'ı entegre etmek için `Update-Database [Migration Adı]` komutunu kullanabilirsiniz.

## Kod Üzerinden Migrate Etme

```csharp
AppDbContext context = new();
await context.Database.MigrateAsync();
