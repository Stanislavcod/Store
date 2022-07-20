using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Entities
{
    [Table("Managers")]
    public class Manager:User
    {
        public string Departament { get; set; }
        public int ServiceNumber { get; set; }
        public List<Employee> Employees { get; set; } = new();

    }
}
