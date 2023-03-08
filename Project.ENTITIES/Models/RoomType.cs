using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType:BaseEntity
    {
        public RoomType()
        {
            Rooms = new List<Room>();
        }
        public string RoomTypeName { get; set; }

        



        //Relational Properties

        public virtual List<Room> Rooms { get; set; }
    }
}
