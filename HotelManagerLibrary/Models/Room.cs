using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    //Номер – класс + этаж + собственный номер + количество мест + цена + изображение(временно отсутствует).
    //
    [Serializable]
    public class Room
    {
        Bitmap DBL = new Bitmap(Path.GetFullPath("DBL.jpg"));
        Bitmap DBLTWN = new Bitmap(Path.GetFullPath("DBLTWN.jpg"));
        Bitmap DBLEXB = new Bitmap(Path.GetFullPath("DBLEXB.jpg"));
        Bitmap empty = new Bitmap(Path.GetFullPath("empty.png"));
        public int Id { set; get; }
        public string Type { set; get; }
        public int Floor { set; get; }
        public int Number { set; get; }
        public int ResidentsNumber
        {
            set
            {

            }
            get
            {
                if (Type == "DBL") return 2;
                else if (Type == "DBL TWN") return 2;
                else return 3;
            }
        }
        public int Price { set; get; }
        public Image Image
        {
            set
            {
                
                
            }
            get
            {
                if (Type == "DBL") return DBL;
                else if (Type == "DBL TWN") return DBLTWN;
                else if (Type == "DBL+EXB") return DBLEXB;
                else return empty;
            }
        }
        public bool Occupied { set; get; } = false;

        //public Room(string type, int floor, int number, int residents, int price)
        //{
        //    Type = type;
        //    Floor = floor;
        //    Number = number;
        //    ResidentsNumber = residents;
        //    Price = price;
        //}
    }
}
