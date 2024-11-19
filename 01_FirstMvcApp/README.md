```markdown
# Patika+ BackEnd Web Development Bootcamp 8. E?itimi: Asp.Net Core Bo? �rnek

## Uygulama Gereksinimleri ve Yap?land?rma

Bu pratikte, bir **ASP.NET Core Empty** projesi olu?turup, projedeki yap?lar? **MVC tasar?m deseni**ne uygun olarak yap?land?rman?z beklenmektedir.

### Yap?land?r?lacak Klas�rler

1. **Controllers Klas�r�:**
   - Controllers ad?nda bir klas�r olu?turun.

2. **Models Klas�r�:**
   - Models ad?nda bir klas�r olu?turun.

3. **Views Klas�r�:**
   - Views ad?nda bir klas�r olu?turun.

4. **wwwroot Klas�r�:**
   - wwwroot ad?nda bir klas�r olu?turun.

### Program.cs Dosyas? Konfig�rasyonu

A?a??daki i?lemleri ger�ekle?tirmek i�in **Program.cs** dosyas?nda uygun yap?land?rmalar? yapman?z gerekmektedir:

1. **MVC Servislerinin Eklenmesi:**
   - MVC uygulama �zelliklerini etkinle?tirmek ve hem view'leri hem de controller'lar? kullanabilmek i�in gerekli servisleri ekleyin.
   
2. **Statik Dosyalar?n Kullan?m?n?n Belirtilmesi:**
   - wwwroot klas�r�nde bulunan statik dosyalar?n kullan?lmas?n? sa?layacak konfig�rasyonlar? ekleyin.
   
3. **Routing Konfig�rasyonu:**
   - Taray?c?dan gelen isteklerin do?ru ?ekilde y�nlendirilmesini sa?lamak amac?yla routing yap?land?rmas?n? tamamlay?n.

4. **Varsay?lan Routing:**
   - Anasayfan?z i�in bir varsay?lan routing yap?land?rmas? ekleyin.

### A�?klamalar

**Program.cs** dosyas?n?n en alt k?sm?nda a?a??daki kavramlar? yorum sat?rlar?nda a�?klay?n?z:

- **Controller**: Kullan?c?dan gelen istekleri kar??lar ve uygun bir i? mant??? i?lemi ger�ekle?tirerek sonu�lar? View'e iletir.
- **Action**: Controller i�indeki her bir i?levdir, kullan?c? isteklerini i?leyip sonu�lar? d�nd�r�r.
- **Model**: Veriyi temsil eder ve i? mant??? ile veritaban? etkile?imlerini y�netir.
- **View**: Kullan?c?ya g�sterilen sayfad?r, Model veya Controller'dan gelen veriyi sunar.
- **Razor**: HTML i�indeki dinamik C# kodlar?yla i�eri?i �retmek i�in kullan?lan ?ablonlama motorudur.
- **RazorView**: Razor motorunu kullanan View dosyalar?d?r (�rne?in, `.cshtml`).
- **wwwroot**: Statik dosyalar?n (CSS, JS, resimler) sakland??? dizindir.
- **builder.Build()**: Uygulaman?n yap?land?rma a?amas?n? tamamlayarak �al??maya haz?r hale getirir.
- **app.Run()**: Uygulaman?n ba?lat?lmas?n? ve gelen istekleri dinlemesini sa?lar.

---

## MVC Kavramlar? A�?klamas?

### 1. Controller (Denetleyici)
- **G�revi**: MVC yap?s?nda, kullan?c? isteklerini kar??layarak onlar? i?lemekten sorumludur. Controller, gelen HTTP isteklerini kar??lar, uygun i?lemleri yapar ve sonu�lar? ilgili g�r�n�me (View) y�nlendirir.
- **Nas?l �al???r**: �rne?in, bir �r�n detay?na ula?mak istendi?inde, taray?c?daki istek Controller taraf?ndan al?n?r, gerekli veriler elde edilir, i?lenir ve g�r�n�me g�nderilir.
- **Kullan?m Amac?**: ?? mant???n? ve veriyi alarak kullan?c?ya anlaml? bir �?kt? sunar.

### 2. Action (Eylem)
- **G�revi**: Controller i�inde tan?mlanan bir y�ntemdir. Her bir Action, spesifik bir i?levi yerine getirir.
- **Nas?l �al???r**: �rne?in, bir �r�n eklemek veya silmek i�in `CreateProduct()` ya da `DeleteProduct()` gibi Action�lar kullan?labilir.
- **Kullan?m Amac?**: Kullan?c?n?n yapt??? bir iste?i yerine getirir; �rne?in, veri kaydetme, listeleme, g�ncelleme gibi i?lemler.

### 3. Model
- **G�revi**: Veriyi temsil eder ve veriyle ilgili i?lemleri ger�ekle?tirir. Model, genellikle veritaban?yla etkile?imde bulunur ve i? mant??? ile ba?lant? kurar.
- **Nas?l �al???r**: Model, veritaban?ndan ald??? veriyi Controller�a iletir veya Controller�dan ald??? veriyi veritaban?na kaydeder.
- **Kullan?m Amac?**: Uygulamadaki t�m veri i?lerini �stlenir. �rne?in, kullan?c? bilgilerini veya �r�n listesini temsil eden modeller olabilir.

### 4. View (G�r�n�m)
- **G�revi**: Kullan?c?ya sunulacak olan aray�zd�r. Model veya Controller�dan gelen veriyi al?r ve kullan?c?ya g�sterir.
- **Nas?l �al???r**: �rne?in, bir �r�n listesini kullan?c?ya g�stermek i�in `ProductList` ad?nda bir View olu?turulur ve kullan?c?ya bu listeyi g�rselle?tirerek sunar.
- **Kullan?m Amac?**: Veriyi kullan?c?ya anlaml? bir aray�z �zerinden sunmak.

### 5. Razor
- **G�revi**: ASP.NET MVC�de View (g�r�n�m) olu?turmak i�in kullan?lan bir ?ablonlama motorudur.
- **Nas?l �al???r**: C# kodunu HTML i�erisinde kolayca yazman? sa?lar. `@` i?areti ile C# kodu HTML i�inde �a?r?l?r.
- **Kullan?m Amac?**: Dinamik i�erikler olu?turmak i�in kullan?l?r; �rne?in, bir �r�n fiyat?n? g�stermek i�in `@Model.Price` gibi bir ifade yaz?labilir.

### 6. Razor View
- **G�revi**: Razor motorunu kullanarak bir View dosyas? (�rne?in, `.cshtml` uzant?l? dosyalar) olarak olu?turulmu? sayfalard?r.
- **Nas?l �al???r**: Kullan?c?dan gelen veriyi C# kodu ile i?leyip HTML olarak kullan?c?ya sunar.
- **Kullan?m Amac?**: Controller�dan gelen veriyi kullan?c?ya g�sterir. Dinamik web sayfalar?n?n olu?turulmas?nda kullan?l?r.

### 7. wwwroot
- **G�revi**: Uygulaman?n statik dosyalar?n?n (resimler, CSS, JavaScript dosyalar? gibi) sakland??? dizindir.
- **Nas?l �al???r**: T�m statik dosyalar bu klas�rde bar?nd?r?l?r ve istemciler (kullan?c?lar) do?rudan bu dizine eri?ebilir.
- **Kullan?m Amac?**: Uygulaman?n g�rselli?ini ve etkile?imini sa?lamak i�in gereken dosyalar?n kullan?c?ya do?rudan sunulabilmesi amac?yla kullan?l?r.

---

### 8. builder.Build()
- **G�revi**: MVC uygulamas?nda, uygulama yap?land?rmas?n? tamamlayan ve �al??t?r?labilir hale getiren metottur.
- **Nas?l �al???r**: `builder.Build()` �a?r?ld???nda uygulaman?n middleware (ara katman yaz?l?mlar?) ve di?er servisleri ba?lat?l?r. Bu ad?m tamamland?ktan sonra uygulama kullan?c? isteklerini kar??lamaya haz?r hale gelir.
- **Kullan?m Amac?**: Uygulaman?n yap?land?rma s�recini sonland?rarak �al??maya haz?r hale getirmek.

### 9. app.Run()
- **G�revi**: Uygulaman?n �al??t?r?lmas?n? sa?lar ve gelen HTTP isteklerini dinler.
- **Nas?l �al???r**: `app.Run()` �a?r?ld?ktan sonra uygulama ba?lar ve gelen istekleri dinlemeye ba?lar. Bu metot �al??t?r?ld???nda, uygulama genellikle sonland?r?lana kadar �al??maya devam eder.
- **Kullan?m Amac?**: Uygulaman?n �al??mas?n? ba?latmak ve s�rekli olarak gelen HTTP isteklerini dinlemek.
```