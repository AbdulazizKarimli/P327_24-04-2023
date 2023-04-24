var builder = WebApplication.CreateBuilder(args);

//Service

builder.Services.AddControllersWithViews();

var app = builder.Build();

//Middleware
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();