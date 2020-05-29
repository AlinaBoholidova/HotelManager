using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Постоялець - прізвище + ім'я + стать + дата народження + номер телефону + електронна пошта.
    //
    [Serializable]
    public class Resident
    {
        // Прізвище.   
        public string Surname { get; set; }

        // Ім'я.
        public string Name { get; set; }

        // Стать.
        public string Gender { get; set; }

        // Дата народження.
        public DateTime BirthDate { get; set; }

        // Номер телефону.
        public string Phone { get; set; }

        // Електронна пошта.
        public string Email { get; set; }
    }
}
