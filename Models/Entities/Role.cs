using System;
namespace Ecommerce.Models.Entities
{
	public class Role :Auditables
	{
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}

