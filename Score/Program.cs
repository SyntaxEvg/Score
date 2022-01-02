using Microsoft.EntityFrameworkCore;
using MVM.Services;
using Score.Services.Interface;
using WebStore.DAL.Context;
using WebStore.Services;
using WebStore.Services.InMemory;
using WebStore.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var Service = builder.Services;

Service.AddControllersWithViews(
   //opt.Conventions.Add(Tes
);

Service.AddDbContext<WebStoreDB>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
Service.AddTransient<IDbInitializer, DbInitializer>();
Service.AddSingleton<IEmpData, InMemoryEmpData>();//регистрация сервиса 1ЭКЗЕМЛЯР,НА ВСЕ ВРЕМЯ
Service.AddSingleton<IProductData, InMemoryProductData>();
var app = builder.Build();
await using (var scope = app.Services.CreateAsyncScope())
{
    var db_initializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
    await db_initializer.InitializeAsync(RemoveBefore: false);
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");

app.Run();

