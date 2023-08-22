using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CyberRoads.Data;
using CyberRoads.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CyberRoadsContextConnection") ?? throw new InvalidOperationException("Connection string 'CyberRoadsContextConnection' not found.");

builder.Services.AddDbContext<CyberRoadsContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CyberRoadsUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<CyberRoadsContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();