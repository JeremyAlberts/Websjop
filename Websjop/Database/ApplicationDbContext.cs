using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Websjop.Models;

namespace Websjop.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Product> Product {  get; set; }
        public DbSet<Category> Catergory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .HasMany(e => e.Categories)
               .WithMany(e => e.Products)
               .UsingEntity(
                   j =>
                   {
                       j.Property("ProductsId").HasColumnName("ProductId");
                       j.Property("CategoriesId").HasColumnName("CategoryId");
                   });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Cute Sticker Pack",
                    Price = 4.75M,
                    Description = "A cute sticker pack that can be used anywhere!",
                    Quantity = 12,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Jujutsu Kaisen T-shirt",
                    Price = 19.99M,
                    Description = "Ryouiki Tenkai: Fukuma Mizushi!",
                    Quantity = 20,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id=3,
                    Name = "Cricut Joy",
                    Price = 209.99M,
                    Description = "Perfect present for your loved one!",
                    Quantity = 150,
                    CreatedDate = DateTime.Now
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category 
                { 
                    Id = 1, 
                    Name = "Crafts" 
                },
                new Category
                {
                    Id = 2,
                    Name = "Anime"
                }
            );


        }
    }
}
