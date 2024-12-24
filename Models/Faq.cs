using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class Faq
    {
        public int FaqId { get; set; }
        public int? TourId { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;

        public virtual Tour? Tour { get; set; }
    }
}
