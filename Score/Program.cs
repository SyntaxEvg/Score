using MVM.Services;
var builder = WebApplication.CreateBuilder(args);
var Service = builder.Services;

Service.AddControllersWithViews(
   //opt.Conventions.Add(Tes
);
Service.AddSingleton<IEmpData, InMemoryEmpData>();//ðåãèñòðàöèÿ ñåðâèñà 1ÝÊÇÅÌËßÐ,ÍÀ ÂÑÅ ÂÐÅÌß
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

