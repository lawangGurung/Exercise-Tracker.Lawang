using Exercise_Tracker.EntityFramework.Lawang.Models;
using Microsoft.EntityFrameworkCore;


namespace Exercise_Tracker.EntityFramework.Lawang.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options) {}
    
}
