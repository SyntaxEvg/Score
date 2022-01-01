using MVM.Services;
var builder = WebApplication.CreateBuilder(args);
var Service = builder.Services;

Service.AddControllersWithViews(
   //opt.Conventions.Add(Tes
);
Service.AddSingleton<IEmpData, InMemoryEmpData>();//����������� ������� 1��������,�� ��� �����
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

