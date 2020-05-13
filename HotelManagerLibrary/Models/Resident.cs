using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    [Serializable]
    //Постоялец – фамилия + имя + дата рождения + пол + номер телефона + электронная почта
    public class Resident
    {
        public string Surname { set; get; }
        public string Name { set; get; }
        public DateTime BirthDate { set; get; }
        public string Gender { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
    }
}
