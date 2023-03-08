using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }


        public int? ReservationID { get; set; }


        //Relational Properties
        public virtual EmployeeProfile EmployeeProfile { get; set; }

        public virtual Reservation Reservation { get; set; }


    }
}
