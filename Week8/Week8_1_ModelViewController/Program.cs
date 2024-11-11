using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekle
// -------Neden?
//    MVC'yi kullanabilmek için aşağıdaki metodu kullanarak 
//    hem controller'ları hem de view'ları eklemeliyiz. Aksi
//    halde MVC özellikleri projeye dahil edilmez.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyaları aktifleştir
// -------Neden?
//     Bu adım, uygulamanın wwwroot klasöründe bulunan statik
//     dosyaların kullanıma açılmasını sağlar. CSS ve JS dosyalarına
//     doğrudan erişim, bu komut sayesinde yapılır.
app.UseStaticFiles();


// Tarayıcıdan gelen isteklerin doğru controller ve action metodlarına yönlendirilmesi
// -------Neden?
//     Gelen isteklerin belirli bir route mantığına göre ilgili controller
//     veya action metoduna yönlendirilmesini sağlar. 
app.UseRouting();


// Taleplerin belirli bir controller ve action'a yönlendirilmesi sağlanır
// -------Neden?
//     Kullanıcıların "default" olarak /Home/Index adresine yönlendirilmesini
//     sağlar (id parametresi isteğe bağlıdır). Uygulamanın ana sayfasıdır.
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();

// -----------| Uygulamanın iş mantığını yöneten ve gelen talepleri işleyip uygun 
// CONTROLLER | yanıt dönen bir sınıftır. Gelen isteği alır, çalıştırır ve sonucu bir
// -----------| View veya JSON gibi bir formata döndürür.

// Örnek: ProductController içinde Index isimli bir action barındırır...
// ---------------------------------------------------------------------
//  public class ProductController : Controller
//  {
//      public IActionResult Index()
//      {
//          var products = GetProducts(); // Veritabanından ürünleri alır
//          return View(products); // Products verisi View'e gönderir
//      }
//  }
// *************************************************************************************
// -------| Bir controller içinde belirli bir işlemi gerçekleştiren metottur.
// ACTION | Örneğin, bir ürün listesini göstermek için kullanılabilir. Kullanıcıdan
// -------| gelen isteği alır, iş mantığını çalıştırır ve sonuç olarak View veya veri döner.

// Örnek: Details action metodu, verilen id parametresine göre ürün alır ve View'e gönderir...
// ---------------------------------------------------------------------
//  public IActionResult Details(int id)
//  {
//      var product = GetProductById(id); // Bir ürünü getirir
//      return View(product); // Ürünü View'e gönderir
//  }
// *************************************************************************************
// ------| Model uygulamadaki verileri temsil eden sınıflardır. Bu veriler genellikle
// MODEL | veritabanında tutulur ve kullanıcıya sorulmadan önce işlenir. Veriyi View ve
// ------| Controller arasında yaşıyarak veri temsilini sağlar.

// Örnek: Product modeli, bir ürünün özelliklerini temsil eder...
// ---------------------------------------------------------------------
//  public class Product
//  {
//      public int Id { get; set; }
//      public string Name { get; set; }
//      public decimal Prica { get; set; }
//  }
// *************************************************************************************
// -----| Kullanıcılara gösterilecek olan HTML gibi kullanıcı arayüzü (UI) bileşenlerini içerir.
// VIEW | View ve Controller tarafından sağlanan veriyi gösterir. Veriyi kullanıcıya sunmak için
// -----| HTML ve diğer görsel öğelerle birlikte gösterir.

// Örnek: Bu View, Product listesini gösterir. Model ifadesi, Controller'dan gelen veriyi temsil eder.
// ---------------------------------------------------------------------
//  @model IEnumerable<Product>
//  <h1>Ürün Listesi</h1>
//  <ul>
//      @foreach (var product in Model)
//      {
//          <li>@product.Name - @product.Price TL</li>
//      }  
//  </ul>
// *************************************************************************************
// ------| ASP.NET Core içinde kullanılan bir şablon motorudur. HTML ile C# kodlarının iç içe
// RAZOR | kullanılmasını sağlar. Dinamik HTML sayfaları oluşturmak için kullanılır. '@' sembolü
// ------| ile C# kodları HTML içinde çalıştırılabilir.

// Örnek: @Model ifadesi ile C# kodları HTML ile birlikte kullanılmıştır. Bu sayede ürün bilgileri dinamik olarak HTML içine gömülmüştür.
// ---------------------------------------------------------------------
//  @model Product
//  <h1>@Model.Name</h1>
//  <p>Fiyat: @Model.Price TL</p>
// *************************************************************************************
// ----------| Razor şablon motoru tarafından işlenmiş ve kullanıcıya sunulan HTML sayfasıdır.
// RAZORVIEW | .cshtml uzantısına sahip dosyalardan oluşur. Kullanıcıya sunulmak üzere dinamik
// ----------| içerik oluşturur.
// *************************************************************************************
// --------| ASP.NET Core projelerinde statik dosyaların (CSS, JavaScript, resimler) saklandığı
// wwwroot | klasördür. Kullanıcıların doğrudan erişebileceği statik dosyaları barındırır.
// --------| 
// *************************************************************************************
// ----------------| Uygulamanın tüm yapılandırma işlemlerini tamamlar ve çalışmaya hazır hale
// builder.Build() | getirir. WebApplication nesnesini oluşturur ve uygulamanın çalışmaya başlamasını sağlar.
// ----------------| 

// Örnek: builder.Build() ile app nesnesi oluşturulur ve yapılandırma tamamlanır. app nesnesi uygulamayı temsil eder.
// ---------------------------------------------------------------------
//  var builder = WebApplication.CreateBuilder(args);
//  var app = builder.Build();
// *************************************************************************************
// ----------| Uygulamanın çalışmaya başlaması için kullanılan metottur ve gelen tüm HTTP isteklerini
// app.Run() | dinlemeye başlar. Uygulamanın ana çalıştırma döngüsünü başlatır ve kullanıcı
// ----------| taleplerini karşılamaya hazır hale getirir.


/* ÖZET 
 Controller: İş mantığını yöneten sınıf.
 Action: Controller içinde işlemi gerçekleştiren metot.
 Model: Veriyi temsil eden sınıf.
 View: HTML içeren ve kullanıcıya gösterilecek şablon.
 Razor: HTML ile C#'ı birleştiren şablon motoru.
 RazorView: Dinamik HTML içeren .cshtml dosyası.
 wwwroot: Statik dosyaların tutulduğu klasör.
 builder.Build(): Uygulamanın çalışmaya hazır hale gelmesi.
 app.Run: Uygulamanın çalışmaya başlaması ve taleplerin dinlenmesi.
 */