using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
    }
}
