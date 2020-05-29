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

        // Тип.
        public string Type
        {
            get
            {
                if (Image.Size == CityAbstraction.Size)
                    return "Городская абстракция";
                else if (Image.Size == FootballFan.Size)
                    return "Фанат футбола";
                else if (Image.Size == MorningFreshness.Size)
                    return "Свежесть утра";
                else if (Image.Size == RelaxingPurple.Size)
                    return "Расслабляющий фиолетовый";
                else
                    return "Тип номера";
            }
        }

        // Поверх.
        public int Floor { get; set; }

        // Номер.
        public int Number { get; set; }

        // Кількість місць.
        public int InitialResidents
        {
            get
            {
                if (Image.Size == CityAbstraction.Size)
                    return 2;
                else if (Image.Size == FootballFan.Size)
                    return 2;
                else if (Image.Size == MorningFreshness.Size)
                    return 3;
                else if (Image.Size == RelaxingPurple.Size)
                    return 2;
                else 
                    return 2;
            }
        }

        // Ціна.
        public int Price { get; set; }

        // Зображення.
        public Image Image { get; set; }

        // Стан зайнятості. Початково вільний.
        public bool Occupied { get; set; } = false;

        // Кількість постояльців, що проживають. Початково 0.
        public int ActualResidents { get; set; } = 0;
    }
}
