using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Entities
{
    [Table("Employees")]
    public class Employee:User
    {
        public int ServiceNumber { get; set; }
        public string Name { get; set; }
        public string? Post { get; set; }
        public int? ManagerServiceNumber { get; set; }
        public Manager Manager { get; set; }
    }
}
