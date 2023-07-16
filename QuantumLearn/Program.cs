using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();





/* from stackoverflow
var db = new YourDataContext(optionsBuilder.Options);
db.Database.EnsureDeleted();
db.Database.Migrate();
*/

// from ASP class; trying to delete existing DB and create new because i updated the models w/ new required fields
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();  // give access to context/database for Entity Framework
context.Database.EnsureDeleted();  // if database exists, delete it and start with no pre-existing database
context.Database.EnsureCreated();  // if database doesn't exist, then create it (otherwise do nothing)





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
