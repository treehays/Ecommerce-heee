using System;
using Ecommerce.Models.Enums;

namespace Ecommerce.Models.Entities
{
	public class Cart :Auditables
	{
		public string? CustomerId { get; set; }
		public Customer? Customer { get; set; }
		//public string? OrderId { get; set; }
		public Order Order { get; set; }
		public ICollection<Product>? ProductCart { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.Initiated;
		public string? ReferenceNumber { get; set;}
		public bool MakePayment { get; set; }



		
	}
}

