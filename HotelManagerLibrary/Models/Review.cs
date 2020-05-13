using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    [Serializable]
    //Отзыв – гость + текст отзыва.
    public class Review
    {
        public Guest Guest { set; get; }
        public string Text { set; get; }
    }
}
