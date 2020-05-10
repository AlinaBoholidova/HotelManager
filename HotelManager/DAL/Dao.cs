using HotelManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAL
{
    public class Dao
    {
        Hotel hotel;
        const string filePath = "hotel.bin";

        public Dao(Hotel hotel)
        {
            this.hotel = hotel;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, hotel);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
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
