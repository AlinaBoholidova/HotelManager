using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    [Serializable]
    //Номер – класс + этаж + собственный номер + количество мест + цена + изображение(временно отсутствует).
    public class Room
    {
        public string Type { set; get; }
        public int Floor { set; get; }
        public int Number { set; get; }
        public int ResidentsNumber { set; get; }
        public int Price { set; get; }
    }
}
