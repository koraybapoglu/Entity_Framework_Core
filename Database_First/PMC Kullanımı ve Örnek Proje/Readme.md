# DATABASE FIRST (TERSİNE MÜHENDİSLİK)

## Tersine Mühendislik Nedir?

**Tersine mühendislik**, bir sunucusundaki veritabanının iskelesini kod kısmında oluşturma sürecidir. Bu yaklaşım, var olan bir veritabanının şemasını kullanarak kod tarafında model sınıfları oluşturma sürecini ifade eder. Kısacası, veritabanı şemasını temel alarak kodu oluşturmak anlamına gelir. Bu yaklaşım **Database First** olarak da adlandırılır.

## PMC (PACKAGE MANAGER CONSOLE) ile Tersine Mühendislik

### Scaffold Komutu

**Scaffold komutu**, hedef veritabanını kod kısmında modellemeyi sağlayan bir komuttur. Bu komut, veritabanını kullanarak kod tarafında model sınıflarını oluşturmanıza yardımcı olur.

### PMC ile Database First Komutu

```bash
Scaffold-DbContext 'Connection String' Microsoft.EntityFrameworkCore.[Provider]
