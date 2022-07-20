using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Issuance
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string? Name { get; set; }
        public List<Phone> Phones { get; set; }
    }
}
