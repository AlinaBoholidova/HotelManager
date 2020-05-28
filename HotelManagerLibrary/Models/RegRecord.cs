using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerLibrary.Models
{
    // Запис реєстрації - дата приїзду + дата від'їзду + постоялець + номер + сума до сплати.
    //
    [Serializable]
    public class RegRecord
    {
        public RegRecord()
        {
            //Resident = new Resident();
            //Room = new Room();
        }

        // Конструктор, який приймає номер, постояльця, дату приїзду, дату від'їзду.
        public RegRecord(Room room, Resident resident, DateTime adate, DateTime ddate)
        {
            Room = room;
            Resident = resident;
            ArrivalDate = adate;
            DepartureDate = ddate;
        }

        public DateTime ArrivalDate { set; get; }
        public DateTime DepartureDate { set; get; }
        public Resident Resident { set; get; }
        public Room Room { set; get; }
        public int Total { get => (DepartureDate.Date - ArrivalDate.Date).Days * Room.Price; }

        // Метод для копіювання даних з одного запису реєстрації в інший.
        public void CopyData (RegRecord regRecord1, RegRecord regRecord2)
        {
            regRecord1.ArrivalDate = regRecord2.ArrivalDate;
            regRecord1.DepartureDate = regRecord2.DepartureDate;
            regRecord1.Resident.BirthDate = regRecord2.Resident.BirthDate;
            regRecord1.Resident.Email = regRecord2.Resident.Email;
            regRecord1.Resident.Gender = regRecord2.Resident.Gender;
            regRecord1.Resident.Name = regRecord2.Resident.Name;
            regRecord1.Resident.Phone = regRecord2.Resident.Phone;
            regRecord1.Resident.Surname = regRecord2.Resident.Surname;
            //regRecord1.Room.ActualResidents = regRecord2.Room.ActualResidents;
            //regRecord1.Room.Floor = regRecord2.Room.Floor;
            //regRecord1.Room.Image = regRecord2.Room.Image;
            //regRecord1.Room.Number = regRecord2.Room.Number;
            //regRecord1.Room.Occupied = regRecord2.Room.Occupied;
            //regRecord1.Room.Price = regRecord2.Room.Price;
            regRecord1.Room = regRecord2.Room;
        }

        // Метод для створення назви квитанції.
        public string GetReceiptName(RegRecord regRecord)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "AdminApp.MoveOutForm")
                {
                    return $"recalculation_{regRecord.Resident.Surname}.txt";
                }
            }
            return $"receipt_{regRecord.Resident.Surname}.txt";
        }
    }
}
