using KyivTimes.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KyivTimes.Data
{
    public class KyivTimesDbContext : DbContext
    {
        public KyivTimesDbContext(DbContextOptions<KyivTimesDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
