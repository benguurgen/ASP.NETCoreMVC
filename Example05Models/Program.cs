WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Controllers ve View yap�s�n� service eklentisini dahil ediyoruz.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

//Https otomatik y�nlendirme
app.UseHttpsRedirection();


//css,js vb statik statik sayfalar� �a��rmak i�in ekliyoruz.
app.UseStaticFiles();


//Otomatik rotolama ekliyoruz.
app.MapDefaultControllerRoute();

app.Run();
