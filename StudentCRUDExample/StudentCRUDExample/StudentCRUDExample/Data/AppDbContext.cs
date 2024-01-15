using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
public class AppDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString ="Server=localhost,1433;Database=StudentDb;User Id=admin;"+
        "Password=fptaptech123;TrustServerCertificate=true;";
        optionsBuilder.UseSqlServer(connectionString);

    }
}