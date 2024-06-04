using Microsoft.EntityFrameworkCore ;
using PrimeraPruevaMVC.Entity;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Degree> Degrees {get; set;}
}