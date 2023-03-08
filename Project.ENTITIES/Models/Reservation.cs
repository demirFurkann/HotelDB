using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Reservation:BaseEntity
	{


        public int? CustomerID { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public virtual Customer Customer { get; set; }

		public virtual List<RoomReservation> RoomReservations { get; set; }

		public virtual List<ReservationGuest> ReservationGuests { get; set; }


	}
}
