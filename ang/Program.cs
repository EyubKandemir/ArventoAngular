using ang.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnection")));

builder.Services.AddDbContext<AuthorDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}
app.UseCors(builder =>
{
    builder
       .WithOrigins("http://localhost:44407", "http://localhost:5117")
       .SetIsOriginAllowedToAllowWildcardSubdomains()
       .AllowAnyHeader()
       .AllowCredentials()
       .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
       .SetPreflightMaxAge(TimeSpan.FromSeconds(3600));
}
);
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
