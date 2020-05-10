using HotelManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    [Serializable]
    //Отель – номера, постояльцы, регистрации, гости, отзывы.
    public class Hotel
    {
        public List<Room> Rooms { private set; get; }
        public List<Resident> Residents { private set; get; }
        public List<RegRecord> RegRecords { private set; get; }
        public List<Guest> Guests { private set; get; }
        public List<Review> Reviews { private set; get; }

        public Hotel()
        {
            Rooms = new List<Room>();
            Residents = new List<Resident>();
            RegRecords = new List<RegRecord>();
            Guests = new List<Guest>();
            Reviews = new List<Review>();
        }

        public void FillTestData(int n)
        {
            // Rooms
            Rooms.Clear();
            for (int i = 0; i < n; i++)
            {
                Rooms.Add(new Room()
                {
                    Type = "DBL",
                    Floor = 3,
                    Number = i + 1,
                    ResidentsNumber = 3,
                    Price = (i + 1) * 10
                });
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
                    Type = $"Type {i}",
                    Floor = 3,
                    Number = i + 1,
                    ResidentsNumber = 3,
                    Price = 200
                }, new Resident()
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
