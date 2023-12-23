using System;
namespace Ecommerce.Models.Entities
{
	public class Product : Auditables
	{
		public string? Name { get; set; }
		public int QuantityAvailable { get; set; }
		public double Price { get; set; }
		public double TotalPrice {get; set;}
		public string? CategoryId { get; set; }
		public Category? Category { get; set; }
		public string? CompanyId { get; set; }
		public int QuantityTaken { get; set;}
		public ICollection<ProductCart>? ProductCarts { get; set; }
	}
}

