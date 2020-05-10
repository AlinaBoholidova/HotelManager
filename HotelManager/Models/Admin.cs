using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    //Администратор - имя(логин) + пароль
    public class Admin
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
