using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {
            Orders = new List<Order>();
            RoomReservations = new List<RoomReservation>();
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



        public void TutarHesapla()
        {



            foreach (Order item in Orders)
            {
                UnitPrice = 0;
            }
            foreach (Order item in Orders)
            {
                UnitPrice += item.UnitPrice;
            }


        }
        public string BilgiGoster()
        {
            string isim = "";
            foreach (Order item in Orders)
            {

                isim += $"{item.OrderNo} ,";
            }
            isim.TrimEnd(',');
            if (Orders != null)
            {
                return $"{Customer.FirstName} kişisine : {isim} ";
            }
            return $"{Customer.FirstName} {Customer.LastName}";
        }
        public override string ToString()
        {

            string isim = "";
            if (Orders != null)
            {
                foreach (Order item in Orders)
                {

                    foreach (OrderExtra item1 in item.OrderExtras)
                    {
                        isim += item1.Extra.MealName;
                    }
                }
            }
            string roomNo = "";
            foreach (RoomReservation item in RoomReservations)
            {
                 roomNo += $"{item.Room.RoomNo} ,";
            }
            roomNo.TrimEnd(',');

            return $"{roomNo} isimli odada {Customer.FirstName} {Customer.LastName} kalıyor";
        }


    }
}
