# DOTNET CLI - TERSİNE MÜHENDİSLİK

## Dotnet CLI Komutu

Tersine mühendislik için Dotnet CLI kullanarak, bir sunucudaki veritabanının iskelesini kod kısmında oluşturma süreci gerçekleştirilir. Bu süreç, genellikle "Database First" yaklaşımı olarak adlandırılır.

## Tersine Mühendislik Nedir?

Tersine mühendislik, bir sunucudaki veritabanının şemasını, kod tarafında kullanılabilir model sınıflarına dönüştürme işlemidir. Bu yaklaşım, var olan bir veritabanını kod tarafında kullanabilmek için oldukça yaygın olarak kullanılır.

## Dotnet CLI Komutu

Dotnet CLI kullanarak tersine mühendislik işlemi şu komutla gerçekleştirilebilir:

```bash
dotnet ef dbcontext scaffold 'Connection String' Microsoft.EntityFrameworkCore.[Provider]
