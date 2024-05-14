using Example01.Fonksiyonlar;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Sunucunun davran�� �ekline m�dahale edilebilecek alan
//Veri taban� ba�lant�s� ekleme-pattern ekleme-eklenti ekleme


builder.Services.AddControllersWithViews(); // View yap�s�yla birlikte Controller ekledik.

WebApplication app = builder.Build();

#region Map Yap�s�

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/anasayfa", async (httpContext) =>
//{
//    string page = httpContext.Request.Query["page"];
//    string size = httpContext.Request.Query["size"];
//    string response = $"Anasayfaya ho�geldiniz. Sayfa : {page} Boyut: {size}";

//    //localhost:7106/anasayfa?page=1&size=10

//    await httpContext.Response.WriteAsync(response);
//});


//Web apide bunlar� tekrar g�rece�iz. �imdi mvcye ge�iyoruz yukar�da eklenti k�sm�na bakal�m.

//app.MapGet("/anasayfa", async (httpContext) =>
//{
//    Anasayfa anasayfa = new Anasayfa(httpContext);
//    anasayfa.HelloWorld();
//});
#endregion

//rotadan �nce css i�in statik dosyalar� kullan�labilir hale getirmeliyiz. statik sayfalardan ula�am�yoruz. css bir ara katmand�r 
app.UseStaticFiles();
//ara katmana ulasmak i�in https://localhost:1234/css/main.css

app.UseHsts(); // Header da security durumu kontrol ediyor..

app.UseHttpsRedirection(); // Secure olmayan sayfay� ana porta redirect eder. http->https 

app.MapDefaultControllerRoute(); // otomatik rotalama ekledik. https://localhost:1234/

//E�er deafult �ekilde rota olu�turmak istemiyorsak
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller= Anasayfa}/{action=Index}/{sayfaNo?}");

app.Run();
