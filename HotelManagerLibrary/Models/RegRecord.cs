using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.Models
{
    [Serializable]
    //Регистрация – номер + постоялец + дата приезда + дата отъезда + сумма к оплате.
    public class RegRecord
    {
        public RegRecord(Room room, Resident resident, DateTime adate, DateTime ddate)
        {
            Room = room;
            Resident = resident;
            ArrivalDate = adate;
            DepartureDate = ddate;
            Total = (ddate.Date - adate.Date).Days * Room.Price;
        }

        public DateTime ArrivalDate { set; get; }
        public DateTime DepartureDate { set; get; }
        public Resident Resident { private set; get; }
        public Room Room { private set; get; }
        public int Total { set { } get { return (DepartureDate.Date - ArrivalDate.Date).Days * Room.Price; } }
    }
}
