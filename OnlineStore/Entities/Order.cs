using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int IdIssuance { get; set; }
        public string BuyerLogin { get; set; }
        public Buyer Buyer { get; set; }
        public int EmployeeServiceNumber { get; set; }
        public Employee Employee { get; set; }
        public int ProductId { get; set; }
        public List<Product> Product { get; set; } = new();

    }
}
