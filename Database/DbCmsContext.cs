using Microsoft.EntityFrameworkCore;
using OtterCMSDotNet.Schemas;

namespace OtterCMSDotNet.Database
{
    public class DbCmsContext : DbContext
    {
        public DbCmsContext(DbContextOptions<DbCmsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
