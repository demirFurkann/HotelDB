﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Guest:BaseEntity
	{


        //Relationa Properties

        public virtual List<ReservationGuest> ReservationGuests{ get; set; }
    }
}
