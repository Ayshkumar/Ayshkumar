using System;
using System.Collections.Generic;

namespace TruYumWeb.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public int? UserId { get; set; }

        public virtual MenuItem MenuItem { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
