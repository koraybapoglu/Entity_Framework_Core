# Entity Framework Core Notlarım

Entity Framework Core, .NET uygulamaları için ORM (Object-Relational Mapping) çözümüdür. Veritabanı işlemlerini kod içinde nesne olarak yönetmeyi sağlar.

- Entity Framework Core, veritabanı işlemlerini nesne odaklı bir yaklaşımla yönetmemizi sağlar.
- DbContext sınıfı, veritabanı bağlantısını ve tablo setlerini tanımlar.
- DbSet<T> sınıfı, veritabanında işlem yapılacak nesne türünü belirtir.
- Model sınıfları, veritabanı tablolarına karşılık gelir.
- Migration, veritabanı değişikliklerinin kod olarak temsilidir.
- Migration'lar, Add-Migration komutu ile oluşturulur, Update-Database komutu ile uygulanır.
- Veritabanı bağlantı dizisi, DbContext sınıfının OnConfiguring metodunda tanımlanır.
- Veritabanı provider'ı, DbContext sınıfının OnConfiguring metodunda belirtilir (SqlServer, SQLite, vb.).

Entity Framework Core hakkında daha fazla bilgi edinmek için resmi dokümantasyonu inceleyebilirsiniz.
