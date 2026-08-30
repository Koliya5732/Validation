using Microsoft.EntityFrameworkCore;
using Validation.DbContexts;
using Validation.Models;
using Validation.Services;
// dotnet add package Microsoft.EntityFrameworkCore !!! встановлюємо пакети, інакше код не працюватиме, View > Terminal (або NuGet)
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer !!!

namespace Validation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // отримуємо рядок підключення з конфігураційного файлу, там нова база Files!
            string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

            // реєструємо контекст бази даних для роботи з SQL Server (новий контекст)
            builder.Services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(connection));

            builder.Services.AddControllersWithViews();

            builder.Services.AddMyValidation();

            var app = builder.Build();

            // увімкнення обслуговування статичних файлів з папки wwwroot
            app.UseStaticFiles();
            app.UseStatusCodePagesWithReExecute("/Error404");

            // стандартний маршрут за замовчуванням
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Students}/{action=Index}/{id?}");

            app.Run();
        }
    }
}




