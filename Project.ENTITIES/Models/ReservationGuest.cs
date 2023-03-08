using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class ReservationGuest:BaseEntity
	{
        public int ReservationID { get; set; }

        public int GuestID { get; set; }


        //Relationa Properties

        public virtual Reservation Reservation { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
