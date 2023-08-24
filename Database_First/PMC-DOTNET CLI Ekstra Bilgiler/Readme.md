# DATABASE FIRST (TERSİNE MÜHENDİSLİK)

## Tabloları Belirtme

Varsayılan olarak, veritabanındaki tüm tablolar modellemeye dahil edilir. Ancak sadece istenilen tabloları modellemek için aşağıdaki talimatları kullanabilirsiniz:

### PMC (PACKAGE MANAGER CONSOLE) için;

```bash
Scaffold-DbContext 'Connection String' Microsoft.EntityFrameworkCore.[Provider] -Tables Table1, Table2... 

### DOTNET CLI için;

dotnet ef dbcontext scaffold 'Connection String' Microsoft.EntityFrameworkCore.[Provider] --table Table1 --table Table2 ...


## DbContext Adını Belirtme

Scaffold ile oluşturulan veritabanı modeli için oluşturulacak DbContext nesnesi adı, genellikle veritabanından alınır. Ancak bu adı değiştirmek isterseniz aşağıdaki talimatları kullanabilirsiniz:

### PMC (PACKAGE MANAGER CONSOLE) için;

Scaffold-DbContext 'Connection String' Microsoft.EntityFrameworkCore.[Provider] -Context ContextName


### DOTNET CLI için;

dotnet ef dbcontext scaffold 'Connection String' MicrosoftEntityFrameworkCore.[Provider] --context ContextName


## Path ve Namespace Belirtme

Entity sınıfları ve DbContext sınıfı, varsayılan olarak direkt olarak proje kök dizinine ve projenin varsayılan namespace'ini kullanır. Ancak bu davranışı değiştirmek isterseniz aşağıdaki talimatları kullanabilirsiniz:

### PMC için;

Scaffold DbContext 'Connection String' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models

### DOTNET CLI için;

**dotnet ef dbcontext scaffold 'Connection String' Microsoft.EntityFrameworkCore.[Provider] --context-dir Data --output-dir Models


## Model Güncelleme

Veritabanındaki değişiklikleri kod tarafına yansıtabilmek için Scaffold talimatını yeniden vermeniz gerekebilir. Ancak bu durumda ilgili sınıfların varolduğuna dair hata mesajı alabilirsiniz. Bu tür bir durumda, mevcut dosyaları manuel olarak güncellemek yerine en güncel haliyle tekrar modellendirmek daha iyi bir yaklaşımdır.

Eğer böyle bir durumla karşılaşırsanız, dosyaların varlığına bakılmaksızın en güncel haliyle modellenmelerini sağlamak için şu talimatları kullanabilirsiniz:

### PMC için;

Scaffold -DbContext 'Connection String' EntityFrameworkCore.[Provider] -Force


### DOTNET CLI için;

dotnet ef dbcontext scaffold 'Connection String' Microsoft.EntityFrameworkCore.[Provider] --force




