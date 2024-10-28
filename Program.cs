using CRUD_FSBR.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProcessosDBContext>(options =>
{
    var connString = builder.Configuration.GetConnectionString("ProcessosDBConnection");
    options.UseSqlServer(connString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Processos/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Processos}/{action=Index}/{id?}");

app.Run();
