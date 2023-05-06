using Microsoft.EntityFrameworkCore;
using PieShop.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IPieRepository,PieRepository>();


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PieDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:MyDb"]);
});
var app = builder.Build();

app.UseStaticFiles();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
