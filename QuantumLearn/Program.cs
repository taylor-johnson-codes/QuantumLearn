using Microsoft.EntityFrameworkCore;
using QuantumLearn.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();  // needed for Identity

var app = builder.Build();

// This code was used to recreate the database when the models and model configurations (seed data) were changed
//var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();  // gives access to context/database for Entity Framework
//context.Database.EnsureDeleted();  // if database exists, delete it
//context.Database.EnsureCreated();  // if database doesn't exist, create it (otherwise do nothing)

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();  // needed for Identity

app.Run();
