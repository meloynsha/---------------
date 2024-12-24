using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class Tour
    {
        public Tour()
        {
            Bookings = new HashSet<Booking>();
            Faqs = new HashSet<Faq>();
            Images = new HashSet<Image>();
            Promotions = new HashSet<Promotion>();
            Reviews = new HashSet<Review>();
        }

        public int TourId { get; set; }
        public int? CityId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }

        public virtual City? City { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Faq> Faqs { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
