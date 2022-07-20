using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Assessment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string BuyerLogin { get; set; }
        public Buyer? Buyer { get; set; }
        public ushort? Score { get; set; } // The assessment set by the buyer
    }
}