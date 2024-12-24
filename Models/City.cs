using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class City
    {
        public City()
        {
            Tours = new HashSet<Tour>();
        }

        public int CityId { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
