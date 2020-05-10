using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    //Гость - имя + дата приезда + дата отъезда
    public class Guest
    {
        public string Name { set; get; }
        public DateTime ArrivalDate { set; get; }
        public DateTime DepartureDate { set; get; }
    }
}
