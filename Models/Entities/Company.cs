using System;
namespace Ecommerce.Models.Entities
{
	public class Company : Auditables
    {
		public string? Name { get; set; }
		public string? CacRegNumber { get; set; }
		public string? Logo { get; set; }
		public string? CompanyEmail { get; set; }
		public string? Address { get; set; }
		//public string? ManagerID { get; set; }
		public Manager Manager { get; set; }
		public ICollection<Product>? Products { get; set; }

	}
}

