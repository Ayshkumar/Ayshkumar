using System;
using System.Collections.Generic;

namespace TruYumWeb.Models
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateOfLaunch { get; set; }
        public string Category { get; set; } = null!;
        public bool FreeDelivery { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
