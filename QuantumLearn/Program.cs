using Microsoft.AspNetCore.Identity;
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

var app = builder.Build();

// added this section to load static file SeedData.cs (copying ASP.NET class code and slides)
//var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();  // give access to context/database for Entity Framework
//SeedData.SeedDatabase(context);  // THIS IS WHERE THE ERROR IS WHEN TRYING TO RUN THE APP; 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();  // needed for Identity to work

app.Run();
