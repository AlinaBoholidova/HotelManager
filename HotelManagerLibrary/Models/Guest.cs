using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Гість - звичайний користувач: дата приїзду + дата від'їзду + прізвище-ім'я.
    //
    [Serializable]
    public class Guest
    {
        // Дата приїзду.
        public DateTime ArrivalDate { get; set; }

        // Дата від'їзду.
        public DateTime DepartureDate { get; set; }

        // Прізвище-ім'я гостя.
        public string Login { get; set; }
    }
}
