using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? EmployeeID { get; set; }

        //Relational Properties

        public Employee Employee { get; set; }
        public virtual List<Order> Order { get; set; }
    }

}
