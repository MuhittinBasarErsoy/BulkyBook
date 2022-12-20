using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        //add-migration AddCategoryToDatabase
        //update-database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; } 
    }
}
