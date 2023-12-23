using System;
namespace Ecommerce.Models.Entities
{
	public class Customer : Auditables
    {
		public string? UserId { get; set; }
		public string? TagNumber { get; set; }
		public User User { get; set; }
		//public string? CartId { get; set; }
		public Cart? Cart { get; set; }
	}
}

