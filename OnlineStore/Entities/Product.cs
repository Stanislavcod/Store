using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ushort? Price { get; set; }
        public double? Weight { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
