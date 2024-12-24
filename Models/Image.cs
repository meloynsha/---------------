using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public int? TourId { get; set; }
        public string Url { get; set; } = null!;

        public virtual Tour? Tour { get; set; }
    }
}
