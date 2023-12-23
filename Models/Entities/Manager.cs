using System;
namespace Ecommerce.Models.Entities
{
	public class Manager : Auditables
    {
		public string? UserId { get; set; }
		public User User { get; set; }
		public string? CompanyId { get; set; }
		public Company? Company { get; set; }
		//public Cart? Cart { get; set; }
		//public string? CartId { get; set; }
		public string? StaffNumber { get; set; }



	}
}

