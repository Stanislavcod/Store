using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Entities
{
    public class User
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Phone> Phones { get; set; } = new();
    }
}
