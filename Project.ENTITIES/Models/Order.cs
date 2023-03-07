using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderExtras = new List<OrderExtra>();
            Rooms = new List<Room>();
                
        }
        public decimal UnitPrice { get; set; }
        public int? CustomerID { get; set; }


        //Relational properties

        public virtual List<OrderExtra> OrderExtras { get; set; }

        public virtual List<Room> Rooms { get; set; }

        public virtual Customer Customer { get; set; }


		public override string ToString()
		{
            string isim = null;

            foreach (Room item in Rooms)
            {
                isim += item.RoomNo;
            }
            return $"{isim}No'lu Odada{Customer.FirstName} İsimli müşteri kalıyor";
		}
	}
}
