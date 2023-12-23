using System;
using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
	public class EcommerceContext : DbContext
	{
		public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options)
		{

		}

		public DbSet<Cart> CartDB { get; set; }
        public DbSet<Category> CategoryDB { get; set; }
        public DbSet<Company> CompanyDB { get; set; }
        public DbSet<Customer> CustomerDB { get; set; }
        public DbSet<Manager> ManagerDB { get; set; }
        public DbSet<Order> OrderDB { get; set; }
        public DbSet<Product> ProductDB { get; set; }
        public DbSet<ProductCart> ProductCartDB { get; set; }
        public DbSet<Profile> ProfileDB { get; set; }
        public DbSet<Role> RoleDB { get; set; }
        public DbSet<User> UserDB { get; set; }
        public DbSet<UserRole> UserRoleDB { get; set; }
        public DbSet<Wallet> WalletDB { get; set; }

    }
}

