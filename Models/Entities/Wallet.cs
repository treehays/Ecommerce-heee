using System;
namespace Ecommerce.Models.Entities
{
	public class Wallet: Auditables
	{
		public double NewBalance { get; set; }
		public double Balance { get; set; }
		public string? UserId { get; set; }
		public double Amount { get; set; }
	}
}

