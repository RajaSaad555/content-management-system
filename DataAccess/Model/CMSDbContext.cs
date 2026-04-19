using DataAccess.Model.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Model
{
    // =====================================================
    // 🗄️ CMS DATABASE CONTEXT
    // =====================================================
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }

        // =====================================================
        // 🏗️ DATA TABLES (DBSETS)
        // =====================================================

        // 📄 Content Management:
        public DbSet<CMSPage> CMSPage { get; set; }
        public DbSet<CMSInnerPage> CMSInnerPage { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Slider> Slider { get; set; }

        // 📝 Blogging System:
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BlogCategory> BlogCategory { get; set; }

        // 🛍️ Product Catalog:
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        // 👤 Administration & Lead Generation:
        public DbSet<User> User { get; set; }
        public DbSet<QuickInquiry> QuickInquiry { get; set; }

        // =====================================================
        // ⚙️ MODEL CONFIGURATION (FLUENT API)
        // =====================================================
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 🛠️ Table Mapping: Explicitly defining SQL table names for entities

            // Core CMS Mapping
            modelBuilder.Entity<CMSPage>().ToTable("CMSPage");
            modelBuilder.Entity<CMSInnerPage>().ToTable("CMSInnerPage");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Slider>().ToTable("Slider");
            modelBuilder.Entity<User>().ToTable("User");

            // Blog Mapping
            modelBuilder.Entity<BlogPost>().ToTable("BlogPost");
            modelBuilder.Entity<BlogCategory>().ToTable("BlogCategory");

            // Product & E-Commerce Mapping
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<ProductImage>().ToTable("ProductImages");

            // Communication Mapping
            modelBuilder.Entity<QuickInquiry>().ToTable("QuickInquiry");
        }
    }
}