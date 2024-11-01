using Microsoft.EntityFrameworkCore;

namespace EfLocalDbTest.Data
{
    public class EfLocalDbTestDbContext : DbContext
    {
        public EfLocalDbTestDbContext(DbContextOptions<EfLocalDbTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<CarEntity> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
            => model.Entity<CarEntity>();
    }
}
