using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Request
    {
        // request for delivery of products
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
