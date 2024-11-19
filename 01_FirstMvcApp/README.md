# Patika+ BackEnd Web Development Bootcamp 8. Eğitimi: Asp.Net Core Boş Örnek

## Uygulama Gereksinimleri ve Yapılandırma

Bu pratikte, bir **ASP.NET Core Empty** projesi oluşturup, projedeki yapıları **MVC tasarım deseni**ne uygun olarak yapılandırmanız beklenmektedir.

### Yapılandırılacak Klasörler

1. **Controllers Klasörü:**
   - Controllers adında bir klasör oluşturun.

2. **Models Klasörü:**
   - Models adında bir klasör oluşturun.

3. **Views Klasörü:**
   - Views adında bir klasör oluşturun.

4. **wwwroot Klasörü:**
   - wwwroot adında bir klasör oluşturun.

### Program.cs Dosyası Konfigürasyonu

Aşağıdaki işlemleri gerçekleştirmek için **Program.cs** dosyasında uygun yapılandırmaları yapmanız gerekmektedir:

1. **MVC Servislerinin Eklenmesi:**
   - MVC uygulama özelliklerini etkinleştirmek ve hem view'leri hem de controller'ları kullanabilmek için gerekli servisleri ekleyin.
   
2. **Statik Dosyaların Kullanımının Belirtilmesi:**
   - wwwroot klasöründe bulunan statik dosyaların kullanılmasını sağlayacak konfigürasyonları ekleyin.
   
3. **Routing Konfigürasyonu:**
   - Tarayıcıdan gelen isteklerin doğru şekilde yönlendirilmesini sağlamak amacıyla routing yapılandırmasını tamamlayın.

4. **Varsayılan Routing:**
   - Anasayfanız için bir varsayılan routing yapılandırması ekleyin.

### Açıklamalar

**Program.cs** dosyasının en alt kısmında aşağıdaki kavramları yorum satırlarında açıklayınız:

- **Controller**: Kullanıcıdan gelen istekleri karşılar ve uygun bir iş mantığı işlemi gerçekleştirerek sonuçları View'e iletir.
- **Action**: Controller içindeki her bir işlevdir, kullanıcı isteklerini işleyip sonuçları döndürür.
- **Model**: Veriyi temsil eder ve iş mantığı ile veritabanı etkileşimlerini yönetir.
- **View**: Kullanıcıya gösterilen sayfadır, Model veya Controller'dan gelen veriyi sunar.
- **Razor**: HTML içindeki dinamik C# kodlarıyla içeriği üretmek için kullanılan şablonlama motorudur.
- **RazorView**: Razor motorunu kullanan View dosyalarıdır (örneğin, `.cshtml`).
- **wwwroot**: Statik dosyaların (CSS, JS, resimler) saklandığı dizindir.
- **builder.Build()**: Uygulamanın yapılandırma aşamasını tamamlayarak çalışmaya hazır hale getirir.
- **app.Run()**: Uygulamanın başlatılmasını ve gelen istekleri dinlemesini sağlar.

---

## MVC Kavramları Açıklaması

### 1. Controller (Denetleyici)
- **Görevi**: MVC yapısında, kullanıcı isteklerini karşılayarak onları işlemekten sorumludur. Controller, gelen HTTP isteklerini karşılar, uygun işlemleri yapar ve sonuçları ilgili görünüme (View) yönlendirir.
- **Nasıl Çalışır**: Örneğin, bir ürün detayına ulaşmak istendiğinde, tarayıcıdaki istek Controller tarafından alınır, gerekli veriler elde edilir, işlenir ve görünüme gönderilir.
- **Kullanım Amacı**: İş mantığını ve veriyi alarak kullanıcıya anlamlı bir çıktı sunar.

### 2. Action (Eylem)
- **Görevi**: Controller içinde tanımlanan bir yöntemdir. Her bir Action, spesifik bir işlevi yerine getirir.
- **Nasıl Çalışır**: Örneğin, bir ürün eklemek veya silmek için `CreateProduct()` ya da `DeleteProduct()` gibi Action’lar kullanılabilir.
- **Kullanım Amacı**: Kullanıcının yaptığı bir isteği yerine getirir; örneğin, veri kaydetme, listeleme, güncelleme gibi işlemler.

### 3. Model
- **Görevi**: Veriyi temsil eder ve veriyle ilgili işlemleri gerçekleştirir. Model, genellikle veritabanıyla etkileşimde bulunur ve iş mantığı ile bağlantı kurar.
- **Nasıl Çalışır**: Model, veritabanından aldığı veriyi Controller’a iletir veya Controller’dan aldığı veriyi veritabanına kaydeder.
- **Kullanım Amacı**: Uygulamadaki tüm veri işlerini üstlenir. Örneğin, kullanıcı bilgilerini veya ürün listesini temsil eden modeller olabilir.

### 4. View (Görünüm)
- **Görevi**: Kullanıcıya sunulacak olan arayüzdür. Model veya Controller’dan gelen veriyi alır ve kullanıcıya gösterir.
- **Nasıl Çalışır**: Örneğin, bir ürün listesini kullanıcıya göstermek için `ProductList` adında bir View oluşturulur ve kullanıcıya bu listeyi görselleştirerek sunar.
- **Kullanım Amacı**: Veriyi kullanıcıya anlamlı bir arayüz üzerinden sunmak.

### 5. Razor
- **Görevi**: ASP.NET MVC’de View (görünüm) oluşturmak için kullanılan bir şablonlama motorudur.
- **Nasıl Çalışır**: C# kodunu HTML içerisinde kolayca yazmanı sağlar. `@` işareti ile C# kodu HTML içinde çağrılır.
- **Kullanım Amacı**: Dinamik içerikler oluşturmak için kullanılır; örneğin, bir ürün fiyatını göstermek için `@Model.Price` gibi bir ifade yazılabilir.

### 6. Razor View
- **Görevi**: Razor motorunu kullanarak bir View dosyası (örneğin, `.cshtml` uzantılı dosyalar) olarak oluşturulmuş sayfalardır.
- **Nasıl Çalışır**: Kullanıcıdan gelen veriyi C# kodu ile işleyip HTML olarak kullanıcıya sunar.
- **Kullanım Amacı**: Controller’dan gelen veriyi kullanıcıya gösterir. Dinamik web sayfalarının oluşturulmasında kullanılır.

### 7. wwwroot
- **Görevi**: Uygulamanın statik dosyalarının (resimler, CSS, JavaScript dosyaları gibi) saklandığı dizindir.
- **Nasıl Çalışır**: Tüm statik dosyalar bu klasörde barındırılır ve istemciler (kullanıcılar) doğrudan bu dizine erişebilir.
- **Kullanım Amacı**: Uygulamanın görselliğini ve etkileşimini sağlamak için gereken dosyaların kullanıcıya doğrudan sunulabilmesi amacıyla kullanılır.

---

### 8. builder.Build()
- **Görevi**: MVC uygulamasında, uygulama yapılandırmasını tamamlayan ve çalıştırılabilir hale getiren metottur.
- **Nasıl Çalışır**: `builder.Build()` çağrıldığında uygulamanın middleware (ara katman yazılımlar) ve diğer servisleri başlatılır. Bu adım tamamlandıktan sonra uygulama kullanıcı isteklerini karşılamaya hazır hale gelir.
- **Kullanım Amacı**: Uygulamanın yapılandırma sürecini sonlandırarak çalışmaya hazır hale getirmek.

### 9. app.Run()
- **Görevi**: Uygulamanın çalıştırılmasını sağlar ve gelen HTTP isteklerini dinler.
- **Nasıl Çalışır**: `app.Run()` çağrıldıktan sonra uygulama başlar ve gelen istekleri dinlemeye başlar. Bu metot çalıştırıldığında, uygulama genellikle sonlandırılana kadar çalışmaya devam eder.
- **Kullanım Amacı**: Uygulamanın çalışmasını başlatmak ve sürekli olarak gelen HTTP isteklerini dinlemek.
