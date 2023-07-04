using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopingCart.Models;

namespace WebShopingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<New> GetNews { get; set; }
        public virtual DbSet<NewCategory> GetNewCategories { get; set; }
        public virtual DbSet<NewInCategory> GetNewInCategories { get; set; }

        public virtual DbSet<Product> GetProducts { get; set; }
        public virtual DbSet<CategoryProduct> GetCategoryProducts { get; set; }
        public virtual DbSet<CategoryInProduct> GetProductInCategories { get; set; }

        public virtual DbSet<Oder> GetOders { get; set; }
        public virtual DbSet<OderDetail> GetOderDetails { get; set; }

        public virtual DbSet<Banner> GetBanners { get; set; }
        public virtual DbSet<UserDetail> GetUsers { get; set; }
        public virtual DbSet<Config> GetConfigs { get; set; }
    }
}