using Inventory.Utility.HelperClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Inventory.Repository;
using Inventory.Repository.BillTypeService;
using Inventory.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(
    builder.Configuration.GetConnectionString("ApplicationDbContextConnection")));

builder.Services.AddIdentity<AppUser, IdentityRole>(options => 
options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddScoped<IBillTypeRepo, BillTypeRepo>();
builder.Services.Configure<SuperAdmin>(builder.Configuration.GetSection("SuperAdmin"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
