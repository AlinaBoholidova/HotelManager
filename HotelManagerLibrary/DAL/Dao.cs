using HotelManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerLibrary.DAL
{
    public class Dao
    {
        Hotel hotel;
        //const string filePath = "hotel.bin";
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"AdminApp\bin\Debug\");

        public Dao(Hotel hotel)
        {
            this.hotel = hotel;
        }

        public void Save()
        {
            using (Stream stream = File.Create(path + "hotel.bin"))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, hotel);
                //stream.Position = 0;
            }
            //SaveGuests();
            SaveReviews();
            //SaveRooms();
        }

        //public void SaveGuests()
        //{
        //    using (var wr = new StreamWriter("guests.txt"))
        //    {
        //        wr.WriteLine(hotel.Guests.Count);
        //        foreach (var g in hotel.Guests)
        //        {
        //            wr.WriteLine(g.Name);
        //            wr.WriteLine(g.ArrivalDate);
        //            wr.WriteLine(g.DepartureDate);
        //        }
        //    }
        //}

        public void SaveReviews()
        {
            using (var wr = new StreamWriter(path + "reviews.txt"))
            {
                wr.WriteLine(hotel.Reviews.Count);
                foreach (var r in hotel.Reviews)
                {
                    wr.WriteLine();
                    wr.WriteLine(r.Guest.Name);
                    wr.WriteLine(r.Guest.ArrivalDate);
                    wr.WriteLine(r.Guest.DepartureDate);
                    wr.WriteLine(r.Text);
                }
            }
        }

        //public void SaveRooms()
        //{
        //    using (var wr = new StreamWriter(path + "rooms.txt"))
        //    {
        //        wr.WriteLine(hotel.Rooms.Count);
        //        foreach (var r in hotel.Rooms)
        //        {
        //            wr.WriteLine(r.Type);
        //            wr.WriteLine(r.Floor);
        //            wr.WriteLine(r.Number);
        //            wr.WriteLine(r.ResidentsNumber);
        //            wr.WriteLine(r.Price);
        //        }
        //    }
        //}

        public void Load()
        {
            using (Stream stream = File.OpenRead(path + "hotel.bin"))
            {
                var serializer = new BinaryFormatter();
                //stream.Seek(0, SeekOrigin.Begin);
                //stream.Position = 0;
                Hotel ht = (Hotel)serializer.Deserialize(stream);

                Copy(ht.Admins, hotel.Admins);
                Copy(ht.Rooms, hotel.Rooms);
                Copy(ht.Residents, hotel.Residents);
                Copy(ht.RegRecords, hotel.RegRecords);
                Copy(ht.Guests, hotel.Guests);
                //Copy(ht.Reviews, hotel.Reviews);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
            //LoadGuests();
            LoadReviews();
            //LoadRooms();
        }

        //public void LoadGuests()
        //{
        //    using (var rd = new StreamReader("guests.txt"))
        //    {
        //        int n = Convert.ToInt32(rd.ReadLine());
        //        hotel.Guests.Clear();
        //        for (int i = 0; i < n; i++)
        //        {
        //            var name = rd.ReadLine();
        //            var arrdate = Convert.ToDateTime(rd.ReadLine());
        //            var ddate = Convert.ToDateTime(rd.ReadLine());
        //            hotel.Guests.Add(new Guest { Name = name, ArrivalDate = arrdate, DepartureDate = ddate });
        //        }
        //    }
        //}

        public void LoadReviews()
        {
            using (var rd = new StreamReader(path + "reviews.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                hotel.Reviews.Clear();
                for (int i = 0; i < n; i++)
                {
                    rd.ReadLine();
                    var name = rd.ReadLine();
                    rd.ReadLine();
                    rd.ReadLine();
                    var text = rd.ReadLine();
                    hotel.Reviews.Add(new Review { Guest = GetGuestByName(name), Text = text });
                }
            }
        }

        public Guest GetGuestByName(string name) => hotel.Guests.Single(g => g.Name == name);

        //public void LoadRooms()
        //{
        //    using (var rd = new StreamReader(path + "rooms.txt"))
        //    {
        //        int n = Convert.ToInt32(rd.ReadLine());
        //        hotel.Rooms.Clear();
        //        for (int i = 0; i < n; i++)
        //        {
        //            var type = rd.ReadLine();
        //            var floor = Convert.ToInt32(rd.ReadLine());
        //            var number = Convert.ToInt32(rd.ReadLine());
        //            var resnumb = Convert.ToInt32(rd.ReadLine());
        //            var price = Convert.ToInt32(rd.ReadLine());
        //            hotel.Rooms.Add(new Room
        //            {
        //                Type = type,
        //                Floor = floor,
        //                Number = number,
        //                ResidentsNumber = resnumb,
        //                Price = price
        //            });
        //        }
        //    }
        //}
    }
}
