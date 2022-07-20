using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Entities
{
    public class Card
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string BuyerLogin { get; set; }
        public Buyer Buyer { get; set; }
    }
}
