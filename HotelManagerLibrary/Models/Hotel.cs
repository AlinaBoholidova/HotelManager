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
    [Serializable]
    //Отель – номера, постояльцы, регистрации, гости, отзывы.
    //
    public class Hotel
    {
        public List<Admin> Admins { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<RegRecord> RegRecords { private set; get; }
        public List<Resident> Residents { private set; get; }
        public List<Review> Reviews { private set; get; }
        public List<Room> Rooms { private set; get; }

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
        
        public bool IsFull()
        {
            return Rooms.All(x => x.Occupied == true);
        }

        public void ConnectAdmins()
        {
            Admins.Clear();
            Admins.Add(new Admin { Name = "Мария", Password = "197909" });
            Admins.Add(new Admin { Name = "Александр", Password = "271242" });
            Admins.Add(new Admin { Name = "Дмитрий", Password = "631903" });
        }

        public void FillTestData(int n)
        {
            // Rooms
            Rooms.Clear();
            var noImage = new Bitmap(Path.GetFullPath("empty.png"));
            for (int i = 0; i < n; i++)
            {
                Rooms.Add(new Room()
                {
                    ActualResidents = 1,
                    Id = i + 1,
                    Floor = 3,
                    Number = (i % 22) + 1,
                    Price = i + 600,
                    Image = noImage
                }
                );
            }
            // Residents
            Residents.Clear();
            for (int i = 1; i <= n; i++)
            {
                Residents.Add(new Resident()
                {
                    Surname = $"ResidentSurname{i}",
                    Name = $"ResidentName{i}",
                    BirthDate = DateTime.Now - TimeSpan.FromDays(i),
                    Gender = "M",
                    Phone = "+1234567",
                    Email = "example@gmail.com"
                });
            }
            // RegRecords
            RegRecords.Clear();
            const int m = 5;
            for (int i = 0; i < n - m; i++)
            {
                RegRecords.Add(new RegRecord(new Room()
                {
                    Id = i,
                    Floor = 3,
                    Number = i % 22,
                    Price = i + 600,
                    Image = noImage,
                    Occupied = true
                }
                , new Resident()
                {
                    Surname = $"ResidentSurname{i}",
                    Name = $"ResidentName{i}",
                    BirthDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                    Gender = "M",
                    Phone = "+1234567",
                    Email = "example@gmail.com"
                }, DateTime.Today, DateTime.Today + TimeSpan.FromDays(i + 1)));
            }
            // Guests
            Guests.Clear();
            for (int i = 0; i <= n; i++)
            {
                Guests.Add(new Guest()
                {
                    Name = $"Name {i}",
                    ArrivalDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                    DepartureDate = DateTime.Today
                });
            }
            // Reviews
            Reviews.Clear();
            for (int i = 0; i <= n; i++)
            {
                Reviews.Add(new Review
                {
                    Guest = new Guest()
                    {
                        Name = $"Name {i}",
                        ArrivalDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                        DepartureDate = DateTime.Today
                    },
                    Text = $"Text {i}"
                });
            }

        }

        public void AddGuest(Guest guest)
        {
            Guests.Add(guest);
        }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

        public void AddRoom(Room room)
        {
            room.Id = Rooms.Max(r => r.Id) + 1;
            Rooms.Add(room);
        }

        public void AddRegRec(RegRecord regRecord)
        {
            regRecord.Room.Occupied = true;
            RegRecords.Add(regRecord);
        }

        public Room FindRoom(int floor, int number)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].Floor == floor && Rooms[i].Number == number)
                {
                    return Rooms[i];
                }
            }
            return Rooms[0];
        }

        public RegRecord FindRegRec(string surname, string phone)
        {
            for (int i = 0; i < RegRecords.Count; i++)
            {
                if (RegRecords[i].Resident.Surname == surname && RegRecords[i].Resident.Phone == phone)
                {
                    return RegRecords[i];
                }
            }
            return RegRecords[0];
        }

        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
