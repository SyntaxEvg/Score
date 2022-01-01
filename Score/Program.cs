using MVM.Services;
using Score.Services.Interface;
using WebStore.Services.InMemory;

var builder = WebApplication.CreateBuilder(args);
var Service = builder.Services;

Service.AddControllersWithViews(
   //opt.Conventions.Add(Tes
);
Service.AddSingleton<IEmpData, InMemoryEmpData>();//регистрация сервиса 1ЭКЗЕМЛЯР,НА ВСЕ ВРЕМЯ
Service.AddSingleton<IProductData, InMemoryProductData>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");

app.Run();

