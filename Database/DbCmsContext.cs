using Microsoft.EntityFrameworkCore;
using OtterCMSDotNet.Schemas;

namespace OtterCMSDotNet.Database
{
    public class DbCmsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=OtterCMS;User Id=sa;Password=your_password;"); // Update with your actual connection string
        }
    }
}
