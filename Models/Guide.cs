using System;
using System.Collections.Generic;

namespace основа.Models
{
    public partial class Guide
    {
        public int GuideId { get; set; }
        public int? UserId { get; set; }
        public string? Bio { get; set; }
        public string? Languages { get; set; }
        public decimal? Rating { get; set; }

        public virtual User? User { get; set; }
    }
}
