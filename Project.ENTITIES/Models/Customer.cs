﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Customer:BaseEntity
	{


        //Relation Properties

        public virtual List<Reservation> Reservations{ get; set; }
    }
}
