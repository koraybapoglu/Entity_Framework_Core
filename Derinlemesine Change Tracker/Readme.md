# Entity Framework Core Change Tracking

Entity Framework Core, .NET tabanlı uygulamalarda veritabanı işlemlerini yönetmek için kullanılan bir ORM (Object-Relational Mapping) aracıdır. Bu README dosyası, Entity Framework Core'da Change Tracking (Değişiklik Takibi) ve ilgili methodları anlatmaktadır.

## Change Tracking Nedir?

Change Tracking, Entity Framework Core'un veritabanı işlemleri sırasında nesnelerin durumlarını izlemesi ve takip etmesi işlemidir. Bu, nesnelerin veritabanında nasıl değiştirildiğini veya güncellendiğini belirlemek için kullanılır. Değişiklik takibi, performansı artırır ve veritabanı işlemlerini optimize eder.

## DetectChanges Methodu

`DetectChanges` methodu, Entity Framework Core'un nesneler arasındaki değişiklikleri tespit etmesini sağlar. Genellikle manuel olarak çağrılmaz, çünkü çoğu zaman otomatik olarak değişiklikler algılanır. Ancak bazı özel durumlarda kullanılabilir.

## AutoDetectChanges

`AutoDetectChanges`, Entity Framework Core'un varsayılan davranışını ifade eder. Varsayılan olarak, EF Core otomatik olarak değişiklikleri algılar. Bu nedenle genellikle manuel olarak çağırmaya gerek yoktur.

## Entries Methodu

`Entries` methodu, DbContext içinde bulunan tüm nesnelerin bir listesini döndürür. Bu nesneler, veritabanı işlemleri sırasında değişiklikleri izlemek için kullanılabilir. Örneğin, bir foreach döngüsü ile tüm nesnelerin durumları kontrol edilebilir.

## AcceptAllChanges Methodu

`AcceptAllChanges` methodu, değişiklikleri kabul eder ve nesnelerin durumunu 'Unchanged' durumuna geri döndürür. Yani, nesnelerin üzerindeki değişiklikleri onaylar ve değişiklik takibini sıfırlar.

Bu README dosyası, Entity Framework Core'da Change Tracking ve ilgili methodların temel bir anlatımını içermektedir. Daha fazla bilgi ve örnekler için Entity Framework Core belgelerine başvurabilirsiniz.


## SaveChanges() Methodu

`SaveChanges()` methodu, tüm değişiklikleri veritabanına kaydetmek için kullanılır.

## SaveChanges(true) ve SaveChanges(false)

- `SaveChanges(true)`: Tüm değişiklikleri otomatik olarak veritabanına kaydeder (varsayılan davranış).
- `SaveChanges(false)`: Değişiklikleri bir transaksiyon içinde bekletir, manuel kontrol gerektirir.

Bu methodlar, değişikliklerin nasıl kaydedildiğini kontrol etmek için kullanılır. Hangi yöntemin kullanılacağı projenizin ihtiyaçlarına bağlıdır.



## Entity State Nedir?

Varlık durumu, EF Core'un bir veri tabanı varlığının (entity) durumunu belirlemek için kullandığı temel bir kavramdır. Aşağıda, bu durumların kısa açıklamaları bulunmaktadır:

- **Detached (Ayrık):** Varlık veritabanından ayrılmıştır. Herhangi bir değişiklik takip edilmez.

- **Added (Eklendi):** Varlık, veritabanına yeni eklenmiştir ve `SaveChanges()` ile veritabanına kaydedilecektir.

- **Unchanged (Değişmemiş):** Varlık veritabanında mevcut ve üzerinde herhangi bir değişiklik yapılmamıştır.

- **Modified (Değiştirilmiş):** Varlık veritabanında mevcut ve üzerinde değişiklikler yapılmıştır. Değişiklikler, `SaveChanges()` ile veritabanına uygulanır.

- **Deleted (Silinmiş):** Varlık veritabanından silinmiştir ve `SaveChanges()` ile bu değişiklik veritabanına yansıtılır.

Bu durumlar, EF Core'un varlıkların veritabanı işlemlerini nasıl yönettiğini anlamak için kullanılır. Değişiklikleri izlemek ve uygun işlemleri yapmak için bu durumları kullanabilirsiniz.
