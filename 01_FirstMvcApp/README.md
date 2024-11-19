```markdown
# Patika+ BackEnd Web Development Bootcamp 8. E?itimi: Asp.Net Core Bo? Örnek

## Uygulama Gereksinimleri ve Yap?land?rma

Bu pratikte, bir **ASP.NET Core Empty** projesi olu?turup, projedeki yap?lar? **MVC tasar?m deseni**ne uygun olarak yap?land?rman?z beklenmektedir.

### Yap?land?r?lacak Klasörler

1. **Controllers Klasörü:**
   - Controllers ad?nda bir klasör olu?turun.

2. **Models Klasörü:**
   - Models ad?nda bir klasör olu?turun.

3. **Views Klasörü:**
   - Views ad?nda bir klasör olu?turun.

4. **wwwroot Klasörü:**
   - wwwroot ad?nda bir klasör olu?turun.

### Program.cs Dosyas? Konfigürasyonu

A?a??daki i?lemleri gerçekle?tirmek için **Program.cs** dosyas?nda uygun yap?land?rmalar? yapman?z gerekmektedir:

1. **MVC Servislerinin Eklenmesi:**
   - MVC uygulama özelliklerini etkinle?tirmek ve hem view'leri hem de controller'lar? kullanabilmek için gerekli servisleri ekleyin.
   
2. **Statik Dosyalar?n Kullan?m?n?n Belirtilmesi:**
   - wwwroot klasöründe bulunan statik dosyalar?n kullan?lmas?n? sa?layacak konfigürasyonlar? ekleyin.
   
3. **Routing Konfigürasyonu:**
   - Taray?c?dan gelen isteklerin do?ru ?ekilde yönlendirilmesini sa?lamak amac?yla routing yap?land?rmas?n? tamamlay?n.

4. **Varsay?lan Routing:**
   - Anasayfan?z için bir varsay?lan routing yap?land?rmas? ekleyin.

### Aç?klamalar

**Program.cs** dosyas?n?n en alt k?sm?nda a?a??daki kavramlar? yorum sat?rlar?nda aç?klay?n?z:

- **Controller**: Kullan?c?dan gelen istekleri kar??lar ve uygun bir i? mant??? i?lemi gerçekle?tirerek sonuçlar? View'e iletir.
- **Action**: Controller içindeki her bir i?levdir, kullan?c? isteklerini i?leyip sonuçlar? döndürür.
- **Model**: Veriyi temsil eder ve i? mant??? ile veritaban? etkile?imlerini yönetir.
- **View**: Kullan?c?ya gösterilen sayfad?r, Model veya Controller'dan gelen veriyi sunar.
- **Razor**: HTML içindeki dinamik C# kodlar?yla içeri?i üretmek için kullan?lan ?ablonlama motorudur.
- **RazorView**: Razor motorunu kullanan View dosyalar?d?r (örne?in, `.cshtml`).
- **wwwroot**: Statik dosyalar?n (CSS, JS, resimler) sakland??? dizindir.
- **builder.Build()**: Uygulaman?n yap?land?rma a?amas?n? tamamlayarak çal??maya haz?r hale getirir.
- **app.Run()**: Uygulaman?n ba?lat?lmas?n? ve gelen istekleri dinlemesini sa?lar.

---

## MVC Kavramlar? Aç?klamas?

### 1. Controller (Denetleyici)
- **Görevi**: MVC yap?s?nda, kullan?c? isteklerini kar??layarak onlar? i?lemekten sorumludur. Controller, gelen HTTP isteklerini kar??lar, uygun i?lemleri yapar ve sonuçlar? ilgili görünüme (View) yönlendirir.
- **Nas?l Çal???r**: Örne?in, bir ürün detay?na ula?mak istendi?inde, taray?c?daki istek Controller taraf?ndan al?n?r, gerekli veriler elde edilir, i?lenir ve görünüme gönderilir.
- **Kullan?m Amac?**: ?? mant???n? ve veriyi alarak kullan?c?ya anlaml? bir ç?kt? sunar.

### 2. Action (Eylem)
- **Görevi**: Controller içinde tan?mlanan bir yöntemdir. Her bir Action, spesifik bir i?levi yerine getirir.
- **Nas?l Çal???r**: Örne?in, bir ürün eklemek veya silmek için `CreateProduct()` ya da `DeleteProduct()` gibi Action’lar kullan?labilir.
- **Kullan?m Amac?**: Kullan?c?n?n yapt??? bir iste?i yerine getirir; örne?in, veri kaydetme, listeleme, güncelleme gibi i?lemler.

### 3. Model
- **Görevi**: Veriyi temsil eder ve veriyle ilgili i?lemleri gerçekle?tirir. Model, genellikle veritaban?yla etkile?imde bulunur ve i? mant??? ile ba?lant? kurar.
- **Nas?l Çal???r**: Model, veritaban?ndan ald??? veriyi Controller’a iletir veya Controller’dan ald??? veriyi veritaban?na kaydeder.
- **Kullan?m Amac?**: Uygulamadaki tüm veri i?lerini üstlenir. Örne?in, kullan?c? bilgilerini veya ürün listesini temsil eden modeller olabilir.

### 4. View (Görünüm)
- **Görevi**: Kullan?c?ya sunulacak olan arayüzdür. Model veya Controller’dan gelen veriyi al?r ve kullan?c?ya gösterir.
- **Nas?l Çal???r**: Örne?in, bir ürün listesini kullan?c?ya göstermek için `ProductList` ad?nda bir View olu?turulur ve kullan?c?ya bu listeyi görselle?tirerek sunar.
- **Kullan?m Amac?**: Veriyi kullan?c?ya anlaml? bir arayüz üzerinden sunmak.

### 5. Razor
- **Görevi**: ASP.NET MVC’de View (görünüm) olu?turmak için kullan?lan bir ?ablonlama motorudur.
- **Nas?l Çal???r**: C# kodunu HTML içerisinde kolayca yazman? sa?lar. `@` i?areti ile C# kodu HTML içinde ça?r?l?r.
- **Kullan?m Amac?**: Dinamik içerikler olu?turmak için kullan?l?r; örne?in, bir ürün fiyat?n? göstermek için `@Model.Price` gibi bir ifade yaz?labilir.

### 6. Razor View
- **Görevi**: Razor motorunu kullanarak bir View dosyas? (örne?in, `.cshtml` uzant?l? dosyalar) olarak olu?turulmu? sayfalard?r.
- **Nas?l Çal???r**: Kullan?c?dan gelen veriyi C# kodu ile i?leyip HTML olarak kullan?c?ya sunar.
- **Kullan?m Amac?**: Controller’dan gelen veriyi kullan?c?ya gösterir. Dinamik web sayfalar?n?n olu?turulmas?nda kullan?l?r.

### 7. wwwroot
- **Görevi**: Uygulaman?n statik dosyalar?n?n (resimler, CSS, JavaScript dosyalar? gibi) sakland??? dizindir.
- **Nas?l Çal???r**: Tüm statik dosyalar bu klasörde bar?nd?r?l?r ve istemciler (kullan?c?lar) do?rudan bu dizine eri?ebilir.
- **Kullan?m Amac?**: Uygulaman?n görselli?ini ve etkile?imini sa?lamak için gereken dosyalar?n kullan?c?ya do?rudan sunulabilmesi amac?yla kullan?l?r.

---

### 8. builder.Build()
- **Görevi**: MVC uygulamas?nda, uygulama yap?land?rmas?n? tamamlayan ve çal??t?r?labilir hale getiren metottur.
- **Nas?l Çal???r**: `builder.Build()` ça?r?ld???nda uygulaman?n middleware (ara katman yaz?l?mlar?) ve di?er servisleri ba?lat?l?r. Bu ad?m tamamland?ktan sonra uygulama kullan?c? isteklerini kar??lamaya haz?r hale gelir.
- **Kullan?m Amac?**: Uygulaman?n yap?land?rma sürecini sonland?rarak çal??maya haz?r hale getirmek.

### 9. app.Run()
- **Görevi**: Uygulaman?n çal??t?r?lmas?n? sa?lar ve gelen HTTP isteklerini dinler.
- **Nas?l Çal???r**: `app.Run()` ça?r?ld?ktan sonra uygulama ba?lar ve gelen istekleri dinlemeye ba?lar. Bu metot çal??t?r?ld???nda, uygulama genellikle sonland?r?lana kadar çal??maya devam eder.
- **Kullan?m Amac?**: Uygulaman?n çal??mas?n? ba?latmak ve sürekli olarak gelen HTTP isteklerini dinlemek.
```