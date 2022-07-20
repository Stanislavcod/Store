using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Entities
{
    public class Phone
    {
        [Key]
        public string PhoneNumber { get; set; }
        public string? UserLogin { get; set; }
        public User User { get; set; }
        public int? IssuanceId { get; set; }
        public Issuance Issuance { get; set; }
      

    }
}
