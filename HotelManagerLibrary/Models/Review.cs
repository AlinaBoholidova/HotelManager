using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    // Відгук - гість + текст відгука.
    //
    [Serializable]
    public class Review
    {
        // Гість.
        public Guest Guest { get; set; }

        // Текст відгуку.
        public string Text { get; set; }
    }
}
