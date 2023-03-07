using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {

        public decimal UnitPrice { get; set; }
        public int? CustomerID { get; set; }


        //Relational properties

        public virtual List<OrderExtra> OrderExtras { get; set; }

        public virtual List<Room> Rooms { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
