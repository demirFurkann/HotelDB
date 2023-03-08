﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Order:BaseEntity
	{


        public int? ReservationID { get; set; }

        //Relational Properties

        public virtual Reservation Reservation { get; set; }

		public virtual List<OrderExtra> OrderExtras { get; set; }


	}
}
