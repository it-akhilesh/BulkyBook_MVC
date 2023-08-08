using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = " Ron Parker",
                    Description = "present value the fig",
                    ISBN = "SOTJ005",
                    ListPrice = 30,
                    Price = 50,
                    Price50 = 56,
                    Price100 = 99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "Rock in the SWICHERLAND",
                    Author = "ELEMENT THE VALUE",
                    Description = "present value constant",
                    ISBN = "SOTJ00555555 ",
                    ListPrice = 35,
                    Price = 55,
                    Price50 = 59,
                    Price100 = 101,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );


        }
    }
}
