using System;
using Ecommerce.Models.Enums;

namespace Ecommerce.Models.Entities
{
	public class Order : Auditables
    {
		public string? CartId { get; set; }
		public Cart? Cart { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.Pending;
		public string? OrderRefNumber { get; set; }

			


	}
}

