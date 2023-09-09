using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    public class PromotionsContext : DbContext
    {
        public PromotionsContext(DbContextOptions<PromotionsContext> options)
            : base(options)
        {
        }
        // The DbSet<T> properties correspond to tables to create in the database.
        public DbSet<Coupon> Coupons => Set<Coupon>();
    }
}
