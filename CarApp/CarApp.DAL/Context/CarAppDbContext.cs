using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class CarAppDbContext : DbContext
    {
        public CarAppDbContext(DbContextOptions<CarAppDbContext> options) : base(options)
        {

        }

        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<CarModelEntity> Models { get; set; }
        public DbSet<CarMarkEntity> Marks { get; set; }
    }
}
