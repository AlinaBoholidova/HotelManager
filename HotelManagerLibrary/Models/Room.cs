using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Номер - тип + поверх + власний номер + кількість місць + ціна + зображення +
    // + стан зайнятості + кількість постояльців, що проживають
    //
    [Serializable]
    public class Room
    {
        // Зображення номерів
        Bitmap CityAbstraction = new Bitmap(Path.GetFullPath("CityAbstraction.jpg"));
        Bitmap FootballFan = new Bitmap(Path.GetFullPath("FootballFan.jpg"));
        Bitmap MorningFreshness = new Bitmap(Path.GetFullPath("MorningFreshness.jpg"));
        Bitmap RelaxingPurple = new Bitmap(Path.GetFullPath("RelaxingPurple.jpg"));

        public string Type
        {
            get
            {
                if (Image.Size == CityAbstraction.Size) return "Городская абстракция";
                else if (Image.Size == FootballFan.Size) return "Фанат футбола";
                else if (Image.Size == MorningFreshness.Size) return "Свежесть утра";
                else if (Image.Size == RelaxingPurple.Size) return "Расслабляющий фиолетовый";
                else return "Тип номера";
            }
        }
        public int Floor { set; get; }
        public int Number { set; get; }
        public int InitialResidents
        {
            get
            {
                if (Image.Size == CityAbstraction.Size) return 2;
                else if (Image.Size == FootballFan.Size) return 2;
                else if (Image.Size == MorningFreshness.Size) return 3;
                else if (Image.Size == RelaxingPurple.Size) return 2;
                else return 2;
            }
        }
        public int Price { set; get; }
        public Image Image { set; get; }
        public bool Occupied { set; get; } = false;
        public int ActualResidents { set; get; } = 0;
    }
}
