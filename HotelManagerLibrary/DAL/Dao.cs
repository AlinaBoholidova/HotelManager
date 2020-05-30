using HotelManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerLibrary.DAL
{
    // Dao - клас, який об'єднує методи завантаження та збереження даних.
    //
    public class Dao
    {
        Hotel hotel;
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"AdminApp\bin\Debug\");

        public Dao(Hotel hotel)
        {
            this.hotel = hotel;
        }

        // Метод для збереження даних готелю.
        public void Save()
        {
            using (Stream stream = File.Create(path + "hotel.bin"))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, hotel);
            }
            SaveReviews();
        }

        // Метод для збереження відгуків у окремий файл reviews.txt.
        public void SaveReviews()
        {
            using (var wr = new StreamWriter(path + "reviews.txt"))
            {
                wr.WriteLine(hotel.Reviews.Count);
                foreach (var r in hotel.Reviews)
                {
                    wr.WriteLine();
                    wr.WriteLine(r.Guest.Login);
                    wr.WriteLine(r.Guest.ArrivalDate.Date);
                    wr.WriteLine(r.Guest.DepartureDate.Date);
                    wr.WriteLine(r.Text);
                }
            }
        }

        // Метод для завантаження даних готелю.
        public void Load()
        {
            using (Stream stream = File.OpenRead(path + "hotel.bin"))
            {
                var serializer = new BinaryFormatter();
                Hotel ht = (Hotel)serializer.Deserialize(stream);

                Copy(ht.Rooms, hotel.Rooms);
                Copy(ht.Residents, hotel.Residents);
                Copy(ht.RegRecords, hotel.RegRecords);
                Copy(ht.Guests, hotel.Guests);
                Copy(ht.Reviews, hotel.Reviews);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
