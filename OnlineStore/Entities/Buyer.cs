using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Entities
{
    [Table("Buyers")]
    public class Buyer:User
    {
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public List<Card> Cards { get; set; } = new();

    }
}
