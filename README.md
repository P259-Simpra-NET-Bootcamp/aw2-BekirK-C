# Ödev-2
## Ödev İçeriği
- Staff modelini kullanarak GetAll, GetById , Put , Post , Delete methodlarini icen bir controller implement ediniz.
- Email alanı unique olmalidir.
- Model icin initial migration dosyası ekleyiniz.
- EF ile generic repository ve UnitOfWork kullanabilirsiniz.
- Put ve Post apilerinde model validation hazirlayiniz. Fluent validation kullaniniz.
- Ayrıca 2 tane alana gore (Query parameter) filtreleme yapan Filter apisi ekleyiniz (GET) ve WHERE sarti ile database den filtreleme yapiniz.
- Generic Repository uzerinde Where sartini implement ediniz.
- Proje icerisinde sadece odev ile ilgili kisimlara yer veriniz. Kullanılmayan controller ve methodlari ve yorum satırı  gondermeyiniz.
- Readme file uzerinde nasil calisacagina dair gerekli aciklamalara yer veriniz.
- SOLID e uymaya ozen gosteriniz .
> Tüm istekler karşılandı. 

## Program İçeriği
Proje içerisinde Entities, DataAccess, Business ve WebaPI katmanları bulunmaktadır. Ödev içeriğinde verilen Staff entity ve migration konfigürasyonu için gerekli yapılanma Entities katmanında oluşturulmuştur. DataAccess katmanında SimpraDbContext ile SQL veri tabanı arasında gerekli bağlantı kurulup migration işlemi PM console üzerinden yapılmıştır. Generic yapılanma için GenericRepository class'ında data işlemleri yapılmış ardından Business katmanında DAL işlemleri yapılmıştır. Add ve Update işlemleri için Fluent Validation kullanılmıştır. WebAPI, StaffController'daki HTTP istekleri manager sınıfı üzerinden sağlanmıştır.

- Staff için istenen metotlar controllerda mevcuttur. 
- E-mail alanı unique olarak belirlenmiştir. 
- Migration işlemi yapılmış ve initial_mig dosyası oluşturulmuştur. 
- Data işlemleri için Generic repository oluşturulmuş ve ayrı sınıflar halinde business katmanında kullanılmıştır. 
- Put ve Post metotları için Staff entity'sini doğrulayacak Fluent Validation implementasyonu yapılmıştır. 
- FirstName ve LastName property'leri üzerinden query parameter ile Generic repository'de where komutu ile filtreleme yapılmıştır. 
- SOLID kurallarına uygun hareket edilmiştir.
