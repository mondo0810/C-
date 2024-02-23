using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=mysqlex;User ID=sa;Password=Adminxyz22#;TrustServerCertificate=True;");
    }
}