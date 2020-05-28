using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Гість - звичайний користувач: дата приїзду + дата від'їзду + ім'я.
    //
    [Serializable]
    public class Guest
    {
        public DateTime ArrivalDate { set; get; }
        public DateTime DepartureDate { set; get; }
        public string Name { set; get; }
    }
}
