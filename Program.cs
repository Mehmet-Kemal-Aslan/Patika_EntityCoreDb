using Microsoft.EntityFrameworkCore;
using EFCoreDB;
using EFCoreDB.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database connection
var connectionString = builder.Configuration.GetConnectionString("DbEducation");
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options =>
options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();