using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime DateTime { get; set; }
        public string? Status { get; set; }
        public int EmployeeServiceNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
