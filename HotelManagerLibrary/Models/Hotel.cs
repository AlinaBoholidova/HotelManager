using HotelManagerLibrary.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HotelManagerLibrary.Models
{
    // Готель - це адміністратори, номери, постояльці, записи реєстрацій, гості, відгуки.
    //
    [Serializable]
    public class Hotel
    {
        // Якщо дані були змінені.
        public bool IsDirty;

        public Hotel()
        {
            Admins = new List<Admin>();
            Guests = new List<Guest>();
            RegRecords = new List<RegRecord>();
            Residents = new List<Resident>();
            Reviews = new List<Review>();
            Rooms = new List<Room>();
            ConnectAdmins();
        }

        // Список адміністраторів.
        public List<Admin> Admins { get; private set; }
        // Список номерів.
        public List<Room> Rooms { get; private set; }
        // Список постояльців.
        public List<Resident> Residents { get; private set; }
        // Список записів реєстрацій.
        public List<RegRecord> RegRecords { get; private set; }
        // Список гостей.
        public List<Guest> Guests { get; private set; }
        // Список відгуків.
        public List<Review> Reviews { get; private set; }

        // Метод для додавання нового гостя.
        public void AddGuest(Guest guest)
        {
            Guests.Add(guest);
        }

        // Метод для додавання нового відгуку.
        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

        // Метод для додавання нового запису реєстрації.
        public void AddRegRec(RegRecord regRecord)
        {
            regRecord.Room.Occupied = true;
            RegRecords.Add(regRecord);
        }


        // Метод для додавання нового номеру.
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        // Метод для перевірки наявності номерів для додавання.
        public bool CheckFreeRooms()
        {
            // У готелі 6 поверхів з 20 номерами на кожному.
            if (Rooms.Count != 120)
            {
                return true;
            }
            return false;
        }

        // Метод для підключення існуючих пар ім'я (адміністратора) + пароль до системи готелю.
        public void ConnectAdmins()
        {
            Admins.Clear();
            Admins.Add(new Admin { Name = "Дмитрий", Password = "197909" });
            Admins.Add(new Admin { Name = "Елена", Password = "010569" });
            Admins.Add(new Admin { Name = "Сергей", Password = "031963" });
        }

        // Метод для завантаження тестових даних.
        public void FillTestData(int n)
        {
            // Номери
            Rooms.Clear();
            var noImage = new Bitmap(Path.GetFullPath("empty.png"));
            for (int i = 0; i < n; i++)
            {
                Rooms.Add(new Room()
                {
                    ActualResidents = 1,
                    Occupied = true,
                    Floor = (i % 6) + 1,
                    Number = (i % 20) + 1,
                    Price = i + 600,
                    Image = noImage
                }
                );
            }
            // Постояльці
            Residents.Clear();
            for (int i = 0; i < n; i++)
            {
                Residents.Add(new Resident()
                {
                    Surname = $"ResidentSurname{i}",
                    Name = $"ResidentName{i}",
                    BirthDate = DateTime.Now - TimeSpan.FromDays(i),
                    Gender = "M",
                    Phone = "123456789",
                    Email = "example@gmail.com"
                });
            }
            // Записи реєстрацій
            RegRecords.Clear();
            for (int i = 0; i < n; i++)
            {
                RegRecords.Add(new RegRecord(new Room()
                {
                    ActualResidents = 1,
                    Floor = (i % 6) + 1,
                    Number = (i % 20) + 1,
                    Price = i + 600,
                    Image = noImage,
                    Occupied = true
                }
                , new Resident()
                {
                    Surname = $"ResidentSurname{i}",
                    Name = $"ResidentName{i}",
                    BirthDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                    Gender = "-",
                    Phone = "123456789",
                    Email = "example@gmail.com"
                }, DateTime.Today, DateTime.Today + TimeSpan.FromDays(i + 1)));
            }
            // Гості
            Guests.Clear();
            for (int i = 0; i < n; i++)
            {
                Guests.Add(new Guest()
                {
                    Login = $"Name{i}",
                    ArrivalDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                    DepartureDate = DateTime.Today
                });
            }
            // Відгуки
            Reviews.Clear();
            for (int i = 0; i < n; i++)
            {
                Reviews.Add(new Review
                {
                    Guest = new Guest()
                    {
                        Login = $"Name{i}",
                        ArrivalDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                        DepartureDate = DateTime.Today
                    },
                    Text = $"Text{i}"
                });
            }
        }

        // Метод для пошуку адміністратора з переданими даними.
        public bool FindAdmin(string name, string password)
        {
            foreach (var a in Admins)
            {
                if (a.Name == name && a.Password == password)
                    return true;
            }
            return false;
        }

        // Метод для пошуку запису реєстрації.
        public RegRecord FindRegRec(string surname, string phone)
        {
            for (int i = 0; i < RegRecords.Count; i++)
            {
                if (RegRecords[i].Resident.Surname == surname && RegRecords[i].Resident.Phone == phone)
                {
                    return RegRecords[i];
                }
            }
            return null;
        }

        // Метод для пошуку номера.
        public Room FindRoom(int floor, int number)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].Floor == floor && Rooms[i].Number == number)
                {
                    return Rooms[i];
                }
            }
            return null;
        }

        // Метод для перевірки наявності вільних номерів у готелі.
        public bool IsFull()
        {
            return Rooms.All(x => x.Occupied == true);
        }

        // Метод для видалення запису реєстрації.
        public void RemoveRegRec(RegRecord regRecord)
        {
            regRecord.Room.Occupied = false;
            regRecord.Room.ActualResidents = 0;
            RegRecords.Remove(regRecord);
        }

        // Метод для збереження даних готелю.
        public void Save()
        {
            new Dao(this).Save();
        }

        // Метод для завантаження даних готелю.
        public void Load()
        {
            new Dao(this).Load();
        }
    }
}