using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Guides = new HashSet<Guide>();
            Reviews = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Guide> Guides { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
