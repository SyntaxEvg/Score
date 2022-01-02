using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVM.Services;
using Score.Services.Interface;
using WebStore.DAL.Context;
using WebStore.Domain.Entities.Identity;
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

Service.AddIdentity<User, Role>()
.AddEntityFrameworkStores<WebStoreDB>().AddDefaultTokenProviders();
Service.Configure<IdentityOptions>(
    opt =>
    {
#if DEBUG
        opt.Password.RequireDigit = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequiredLength = 3;
        opt.Password.RequiredUniqueChars = 3;
#endif

        opt.User.RequireUniqueEmail = false;
        opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ1234567890";

        opt.Lockout.AllowedForNewUsers = false;
        opt.Lockout.MaxFailedAccessAttempts = 10;
        opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    }
    );
Service.ConfigureApplicationCookie(opt =>
{
    opt.Cookie.Name = "WebStore.GB";
    opt.Cookie.HttpOnly = true;

    //opt.Cookie.Expiration = TimeSpan.FromDays(10); // устарело
    opt.ExpireTimeSpan = TimeSpan.FromDays(10);

    opt.LoginPath = "/Account/Login";
    opt.LogoutPath = "/Account/Logout";
    opt.AccessDeniedPath = "/Account/AccessDenied";

    opt.SlidingExpiration = true;
});
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

