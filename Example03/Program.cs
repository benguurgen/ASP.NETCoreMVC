WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //1

builder.Services.AddControllersWithViews(); //2 - application olusturmadan �nce view eklemeliyiz.

WebApplication app = builder.Build(); //3


//app.MapDefaultControllerRoute(); //4

app.MapControllerRoute( //bu yapt���m�z manuel map route 

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //5

// 6 MVC projemiz haz�r. Controller klas�r� ve HomeController a��yoruz