using System;
namespace Ecommerce.Models.Entities
{
	public class ProductCart :Auditables
	{
		public string? ProductId { get; set; }
		public string? CartId { get; set; }
		public Cart? Cart { get; set; }
		public Product? Product { get; set; }


	}
}

