using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsSourse.Models
{
    public class City
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int Population { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
