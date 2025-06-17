using DynamicTimetable.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IApiClientService, ApiClientService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7006/");
});

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TimeTable}/{action=Index}/{id?}");

app.Run();
