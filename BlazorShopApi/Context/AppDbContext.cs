using BlazorShopApi.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlazorShopApi.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Cart> Carts { get; set; } = null!;
		public DbSet<CartItem> CartItems { get; set; } = null!;
		public DbSet<Category> Categories { get; set; } = null!;
		public DbSet<Products> Products { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.HasData(
					new Category { Id = 1, Name = "Electronics", IconCSS = "fa-solid fa-mobile" },
					new Category { Id = 2, Name = "Clothing", IconCSS = "fa-solid fa-tshirt" },
					new Category { Id = 3, Name = "Books", IconCSS = "fa-solid fa-book" },
					new Category { Id = 4, Name = "Home & Kitchen", IconCSS = "fa-solid fa-blender" },
					new Category { Id = 5, Name = "Sports", IconCSS = "fa-solid fa-football" },
					new Category { Id = 6, Name = "Beauty", IconCSS = "fa-solid fa-lipstick" },
					new Category { Id = 7, Name = "Toys", IconCSS = "fa-solid fa-baby-carriage" },
					new Category { Id = 8, Name = "Automotive", IconCSS = "fa-solid fa-car" },
					new Category { Id = 9, Name = "Health", IconCSS = "fa-solid fa-heart" },
					new Category { Id = 10, Name = "Grocery", IconCSS = "fa-solid fa-apple-alt" }
				);
			modelBuilder.Entity<Products>()
				.HasData(new Products { Id = 1, Name = "Smartphone", Description = "Latest model smartphone with advanced features.", ImageUrl = "https://example.com/smartphone.jpg", Price = 699.99m, Quantity = 50, CategoryId = 1 },
					new Products { Id = 2, Name = "Laptop", Description = "High-performance laptop for gaming and work.", ImageUrl = "https://example.com/laptop.jpg", Price = 1299.99m, Quantity = 30, CategoryId = 1 },
					new Products { Id = 3, Name = "T-shirt", Description = "Comfortable cotton t-shirt.", ImageUrl = "https://example.com/tshirt.jpg", Price = 19.99m, Quantity = 100, CategoryId = 2 },
					new Products { Id = 4, Name = "Jeans", Description = "Stylish denim jeans.", ImageUrl = "https://example.com/jeans.jpg", Price = 49.99m, Quantity = 75, CategoryId = 2 },
					new Products { Id = 5, Name = "Novel", Description = "Bestselling novel of the year.", ImageUrl = "https://example.com/novel.jpg", Price = 14.99m, Quantity = 200, CategoryId = 3 },
					new Products { Id = 6, Name = "Cookbook", Description = "Delicious recipes for home cooking.", ImageUrl = "https://example.com/cookbook.jpg", Price = 24.99m, Quantity = 150, CategoryId = 3 },
					new Products { Id = 7, Name = "Headphones", Description = "Noise-cancelling over-ear headphones.", ImageUrl = "https://example.com/headphones.jpg", Price = 199.99m, Quantity = 40, CategoryId = 1 },
					new Products { Id = 8, Name = "Smartwatch", Description = "Fitness tracking smartwatch with heart rate monitor.", ImageUrl = "https://example.com/smartwatch.jpg", Price = 249.99m, Quantity = 60, CategoryId = 1 },
					new Products { Id = 9, Name = "Sneakers", Description = "Comfortable running sneakers.", ImageUrl = "https://example.com/sneakers.jpg", Price = 79.99m, Quantity = 80, CategoryId = 2 },
					new Products { Id = 10, Name = "Graphic Novel", Description = "Illustrated graphic novel with stunning artwork.", ImageUrl = "https://example.com/graphicnovel.jpg", Price = 29.99m, Quantity = 120, CategoryId = 3 },
					new Products { Id = 11, Name = "Tablet", Description = "Portable tablet for work and entertainment.", ImageUrl = "https://example.com/tablet.jpg", Price = 499.99m, Quantity = 20, CategoryId = 1 },
					new Products { Id = 12, Name = "Jacket", Description = "Warm and stylish winter jacket.", ImageUrl = "https://example.com/jacket.jpg", Price = 89.99m, Quantity = 55, CategoryId = 2 },
					new Products { Id = 13, Name = "E-reader", Description = "Lightweight e-reader with built-in light.", ImageUrl = "https://example.com/ereader.jpg", Price = 119.99m, Quantity = 90, CategoryId = 3 },
					new Products { Id = 14, Name = "Bluetooth Speaker", Description = "Portable Bluetooth speaker with great sound.", ImageUrl = "https://example.com/speaker.jpg", Price = 89.99m, Quantity = 70, CategoryId = 1 },
					new Products { Id = 15, Name = "Backpack", Description = "Durable backpack for travel and school.", ImageUrl = "https://example.com/backpack.jpg", Price = 39.99m, Quantity = 110, CategoryId = 2 },
					new Products { Id = 16, Name = "Cookware Set", Description = "Non-stick cookware set for home chefs.", ImageUrl = "https://example.com/cookware.jpg", Price = 149.99m, Quantity = 45, CategoryId = 3 }
				);
			modelBuilder.Entity<User>()
				.HasData(new User { Id = 1, UserName = "Ana Paula" },
					new User { Id = 2, UserName = "Lucas Silva" },
					new User { Id = 3, UserName = "Maria Oliveira" },
					new User { Id = 4, UserName = "Carlos Santos" },
					new User { Id = 5, UserName = "Fernanda Costa" },
					new User { Id = 6, UserName = "Rafael Almeida" },
					new User { Id = 7, UserName = "Juliana Pereira" },
					new User { Id = 8, UserName = "Gabriel Rocha" },
					new User { Id = 9, UserName = "Isabella Lima" },
					new User { Id = 10, UserName = "Matheus Martins" }
				);
			modelBuilder.Entity<Cart>()
				.HasData(new Cart { Id = 1 },
					new Cart { Id = 2 },
					new Cart { Id = 3 },
					new Cart { Id = 4 },
					new Cart { Id = 5 },
					new Cart { Id = 6 },
					new Cart { Id = 7 },
					new Cart { Id = 8 },
					new Cart { Id = 9 },
					new Cart { Id = 10 }
				);
		}
	}
}

