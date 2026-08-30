using Microsoft.EntityFrameworkCore;
using Validation.Models;

namespace Validation.DbContexts
{
    // для взаємодії з MS SQL Server через Entity Framework потрібен пакет
    // Microsoft.EntityFrameworkCore.SqlServer
    // для створення БД на основі моделі потрібен пакет Microsoft.EntityFrameworkCore.Tools
    // Entity Framework Core використовує підхід Code First, при якому спочатку
    // визначаються моделі та контекст даних, а потім на їх основі створюється БД і всі таблиці.
    public class MyDbContext : DbContext
    {
        // кожна властивість типу DbSet відповідатиме окремій таблиці в базі даних
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.EnsureCreated(); // створює базу даних, якщо вона ще не існує
        }
    }
}
