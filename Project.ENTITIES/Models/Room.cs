using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }

        public decimal UnitPrice { get; set; }

       

        public int? RoomTypeID { get; set; }
      

        //Relational Properties

        public virtual RoomType RoomType { get; set; }

        public virtual List<RoomReservation> RoomReservations { get; set; }


        public string BilgiGoster()
        {
            return $" Fiyatı:{UnitPrice:C2}\n Odanın tipi: {RoomType.RoomTypeName}";
        }
        public override string ToString()
        {
            return $" Oda Adi: {RoomNo}";
        }
    }
}
