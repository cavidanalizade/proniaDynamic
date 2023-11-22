using Microsoft.EntityFrameworkCore;
using PraniaWA.Models;

namespace PraniaWA.DAL
{
    public class AppDBC:DbContext
    {
        public AppDBC(DbContextOptions<AppDBC> options):base(options) 
        {
            
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductImage> productsImages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
