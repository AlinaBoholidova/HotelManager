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
        public RegRecord() { }
        
        // Конструктор, який приймає номер, постояльця, дату приїзду, дату від'їзду.
        public RegRecord(Room room, Resident resident, DateTime adate, DateTime ddate)
        {
            Room = room;
            Resident = resident;
            ArrivalDate = adate;
            DepartureDate = ddate;
        }

        // Дата приїзду постояльця.
        public DateTime ArrivalDate { get; set; }

        // Дата від'їзду постояльця.
        public DateTime DepartureDate { get; set; }

        // Дані постояльця.
        public Resident Resident { get; set; }

        // Дані номера, у який заселений постоялець.
        public Room Room { get; set; }

        // Підрахунок суми до сплати.
        public int Total
        { 
            get
            {
                return (DepartureDate.Date - ArrivalDate.Date).Days * Room.Price;
            }
        }

        // Метод для копіювання даних з одного запису реєстрації в інший.
        public void CopyData(RegRecord regRecord1, RegRecord regRecord2)
        {
            regRecord1.ArrivalDate = regRecord2.ArrivalDate;
            regRecord1.DepartureDate = regRecord2.DepartureDate;
            regRecord1.Resident.BirthDate = regRecord2.Resident.BirthDate;
            regRecord1.Resident.Email = regRecord2.Resident.Email;
            regRecord1.Resident.Gender = regRecord2.Resident.Gender;
            regRecord1.Resident.Name = regRecord2.Resident.Name;
            regRecord1.Resident.Phone = regRecord2.Resident.Phone;
            regRecord1.Resident.Surname = regRecord2.Resident.Surname;
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
