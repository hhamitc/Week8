var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
Controller: Kullanıcı etkileşimlerini yönetir. Gelen istekleri alır, modeli günceller ve uygun görünümü (view) seçerek kullanıcıya sunar.

 
Action: Controller sınıfı içindeki metotlar, bir HTTP isteğine karşılık gelen işlemleri gerçekleştirir. Action metotları, genellikle bir view'e yönlendirme yapar veya JSON gibi farklı bir çıktı üretir.


Model: Veriyi temsil eder. Veritabanından gelen veya kullanıcıdan alınan verileri tutar ve işler.


View: Kullanıcı arayüzünü tanımlar. Modeldeki verileri kullanarak dinamik HTML sayfaları oluşturur.


Razor: ASP.NET Core'da kullanılan bir sayfa düzenleme motoru. C# kodunu HTML ile karıştırarak dinamik web sayfaları oluşturmamızı sağlar.


Razor View: Razor motorunu kullanılarak oluşturulan bir view dosyasıdır. Genellikle .cshtml uzantısına sahiptir. Controller’dan gelen veriyi kullanıcıya gösterir. Dinamik web sayfalarının oluşturulmasında kullanılır.


wwwroot: Statik dosyaların (CSS, JavaScript, resimler vb.) saklandığı klasördür. Bu dosyalar doğrudan tarayıcıya servis edilir.


builder.Build(): Uygulama yapılandırma işlemini tamamlayarak bir IHostBuilder nesnesi oluşturur. Bu nesne, uygulama çalıştırma için gerekli tüm bilgileri içerir.


app.Run(): Uygulamanın çalıştırılmasını sağlar ve gelen HTTP isteklerini dinler. Uygulamanın çalışmasını başlatmak ve sürekli olarak gelen HTTP isteklerini dinlemek.

 
 */