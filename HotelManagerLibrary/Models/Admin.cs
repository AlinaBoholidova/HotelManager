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
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
