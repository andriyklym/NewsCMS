using System.Data.Entity;
using NewsEngine.Models;

namespace NewsEngine.DataAccess
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<News> News { get; set; }
    }
}
