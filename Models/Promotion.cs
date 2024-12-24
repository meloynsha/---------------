using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class Promotion
    {
        public int PromotionId { get; set; }
        public int? TourId { get; set; }
        public decimal Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Tour? Tour { get; set; }
    }
}
