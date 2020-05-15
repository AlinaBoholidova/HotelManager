using HotelManagerLibrary.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HotelManagerLibrary.Models
{
    [Serializable]
    //Отель – номера, постояльцы, регистрации, гости, отзывы.
    public class Hotel
    {
        public List<Admin> Admins { private set; get; }
        public List<Room> Rooms { private set; get; }
        public List<Resident> Residents { private set; get; }
        public List<RegRecord> RegRecords { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<Review> Reviews { private set; get; }

        public Hotel()
        {
            Admins = new List<Admin>();
            Rooms = new List<Room>();
            Residents = new List<Resident>();
            RegRecords = new List<RegRecord>();
            Guests = new List<Guest>();
            Reviews = new List<Review>();
        }

        public void FillTestData(int n)
        {
            //Admins
            Admins.Clear();
            Admins.Add(new Admin { Name = "Мария", Password = "197909" });
            Admins.Add(new Admin { Name = "Александр", Password = "271242" });
            Admins.Add(new Admin { Name = "Дмитрий", Password = "631903" });
            // Rooms
            Rooms.Clear();
            var noImage = new Bitmap(Path.GetFullPath("empty.png"));
            for (int i = 0; i < n; i++)
            {
                Rooms.Add(new Room()
                {
                    Id = i,
                    Type = "DBL+EXB",
                    Floor = 3,
                    Number = i % 22,
                    Price = i + 600
                }
                );
            }
            // Residents
            Residents.Clear();
            for (int i = 1; i <= n; i++)
            {
                Residents.Add(new Resident()
                {
                    Surname = $"BuyerSurname{i}",
                    Name = $"BuyerName{i}",
                    BirthDate = DateTime.Now - TimeSpan.FromDays(i),
                    Gender = "M",
                    Phone = "+123456",
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
                    Type = "DBL+EXB",
                    Floor = 3,
                    Number = i % 22,
                    Price = i + 600,
                    Occupied = true
                }
                , new Resident()
                {
                    Surname = $"BuyerSurname{i}",
                    Name = $"BuyerName{i}",
                    BirthDate = DateTime.Now - TimeSpan.FromDays(i),
                    Gender = "M",
                    Phone = "+123456",
                    Email = "example@gmail.com"
                }, DateTime.Now, DateTime.Now + TimeSpan.FromDays(i)));
            }
            // Guests
            Guests.Clear();
            for (int i = 0; i <= n; i++)
            {
                Guests.Add(new Guest()
                {
                    Name = $"Name {i}",
                    ArrivalDate = DateTime.Now - TimeSpan.FromDays(i),
                    DepartureDate = DateTime.Now
                });
            }
            //Reviews
            Reviews.Clear();
            for (int i = 0; i <= n; i++)
            {
                Reviews.Add(new Review
                {
                    Guest = new Guest()
                    {
                        Name = $"Name {i}",
                        ArrivalDate = DateTime.Now - TimeSpan.FromDays(i),
                        DepartureDate = DateTime.Now
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
