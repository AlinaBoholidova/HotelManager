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
        public void CopyData(RegRecord regRecord)
        {
            this.ArrivalDate = regRecord.ArrivalDate;
            this.DepartureDate = regRecord.DepartureDate;
            this.Resident.BirthDate = regRecord.Resident.BirthDate;
            this.Resident.Email = regRecord.Resident.Email;
            this.Resident.Gender = regRecord.Resident.Gender;
            this.Resident.Name = regRecord.Resident.Name;
            this.Resident.Phone = regRecord.Resident.Phone;
            this.Resident.Surname = regRecord.Resident.Surname;
            this.Room = regRecord.Room;
        }

        // Метод для створення назви квитанції.
        public string GetReceiptName()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "AdminApp.MoveOutForm")
                {
                    return $"recalculation_{this.Resident.Surname}.txt";
                }
            }
            return $"receipt_{this.Resident.Surname}.txt";
        }
    }
}
