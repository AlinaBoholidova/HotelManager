using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Адміністратор - авторизований користувач: ім'я + пароль.
    //
    [Serializable]
    
    public class Admin
    {
        // Ім'я.
        public string Name { get; set; }

        // Пароль.
        public string Password { get; set; }
    }
}
