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
        public string Surname { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public DateTime BirthDate { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
    }
}
