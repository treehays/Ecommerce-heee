using System;
namespace Ecommerce.Models.Entities
{
	public class User :Auditables
	{
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        //public string? ProfileId { get; set; }
        public Profile? Profile { get; set; }
        public double WalletBalance { get; set; }
        public Wallet Wallet { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; }

 

    }
}

