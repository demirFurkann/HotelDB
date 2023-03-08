using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Reservation:BaseEntity
	{
        public Reservation()
        {
            Orders = new List<Order>();
        }
        public string ReservationNo { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CustomerID { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public virtual Customer Customer { get; set; }

		public virtual List<RoomReservation> RoomReservations { get; set; }

		public virtual List<ReservationGuest> ReservationGuests { get; set; }


        public string BilgiGoster()
        {
            string isim = "";
            foreach (Order item in Orders)
            {

                foreach (OrderExtra item1 in item.OrderExtras)
                {
                    isim += item1.Extra.MealName;
                }
            }
            if (Orders != null)
            {
                return $"{Customer.FirstName}";
            }
            return $"{Customer.FirstName} {isim} kişisi kalıyor";
        }
        public override string ToString()
        {

            string isim = "";
            foreach (Order item in Orders)
            {
                
                foreach (OrderExtra item1 in item.OrderExtras)
                {
                     isim += item1.Extra.MealName;
                }
            }
            if (Orders !=null)
            {
                return $"{Customer.FirstName}";
            }
            return $"{Customer.FirstName} {isim} kişisi kalıyor";
        }


    }
}
