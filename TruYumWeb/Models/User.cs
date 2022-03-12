using System;
using System.Collections.Generic;

namespace TruYumWeb.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? IsAdmin { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
