WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


// Statik dosyalar�n root klas�r ad�n� de�i�tirmek istersek..
//builder.Enviroment.ContentRootPath="rootFolder";


//Controller ve view yap�s�n� projeye dahil ediyoruz.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();


//Https y�nlendirmesini ve css, js vb statik sayfalar�n �al��mas�n� sa�layal�m.
app.UseHttpsRedirection();
app.UseStaticFiles(); // root folder= wwwroot olarak klas�r olu�turuyoruz.


//Controller seviyesinde otomatik Rotalama i�lemi devreye alal�m
app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name: "public",
//    pattern: "Public/{controller=Home}/{action=Index}/{sayfaNo?}"
//    );

//app.MapControllerRoute(
//    name: "admin",
//    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
//    );

app.Run();
