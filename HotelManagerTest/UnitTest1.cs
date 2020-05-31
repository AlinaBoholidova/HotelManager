using System;
using HotelManagerLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelManagerTest
{
    [TestClass]
    public class HotelTest
    {
        Hotel hotel = new Hotel();
        int test_value = 120;

        [TestMethod]
        public void FillTestData()
        {
            hotel.FillTestData(test_value);
            for (int i = 0; i < test_value; i++)
            {
                Assert.AreEqual($"ResidentSurname{i}", hotel.Residents[i].Surname);
                Assert.AreEqual(600 + i, hotel.Rooms[i].Price);
            }
        }

        [TestMethod]
        public void FindAdmin()
        {
            Assert.IsTrue(hotel.FindAdmin("Дмитрий", "197909"));
            Assert.IsTrue(hotel.FindAdmin("Елена", "010569"));
            Assert.IsTrue(hotel.FindAdmin("Сергей", "031963"));
        }

        [TestMethod]
        public void FindRegRec()
        {
            hotel.FillTestData(test_value);
            for (int i = 0; i < test_value; i++)
            {
                var regRecord = hotel.FindRegRec($"ResidentSurname{i}", "123456789");
                Assert.AreEqual(regRecord.Resident.Surname, hotel.RegRecords[i].Resident.Surname);
                Assert.AreEqual(regRecord.Resident.Phone, hotel.RegRecords[i].Resident.Phone);
            }
        }

        [TestMethod]
        public void FindRoom()
        {
            for (int i = 1; i <= 6; i++)
            {
                Assert.IsNull(hotel.FindRoom(i, 21));
            }
        }

        [TestMethod]
        public void IsFull()
        {
            Assert.IsTrue(hotel.IsFull());
        }
    }

    [TestClass]
    public class RegRecordTest
    {
        [TestMethod]
        public void GetReceiptName()
        {
            Hotel hotel = new Hotel();
            hotel.FillTestData(100);
            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(
                $"receipt_ResidentSurname{i}.txt",
                hotel.RegRecords[i].GetReceiptName());
            }
        }

        [TestMethod]
        public void CopyData()
        {
            Hotel hotel = new Hotel();
            hotel.FillTestData(2);
            hotel.RegRecords[0].CopyData(hotel.RegRecords[1]);
            Assert.AreEqual(hotel.RegRecords[0].ArrivalDate, hotel.RegRecords[1].ArrivalDate);
            Assert.AreEqual(hotel.RegRecords[0].DepartureDate, hotel.RegRecords[1].DepartureDate);
            Assert.AreEqual(hotel.RegRecords[0].Total, hotel.RegRecords[1].Total);
            Assert.AreSame(hotel.RegRecords[0].Room, hotel.Rooms[1]);
            Assert.AreEqual(hotel.RegRecords[0].Resident.Surname, hotel.RegRecords[1].Resident.Surname);
            Assert.AreEqual(hotel.RegRecords[0].Resident.Name, hotel.RegRecords[1].Resident.Name);
            Assert.AreEqual(hotel.RegRecords[0].Resident.Gender, hotel.RegRecords[1].Resident.Gender);
            Assert.AreEqual(hotel.RegRecords[0].Resident.BirthDate, hotel.RegRecords[1].Resident.BirthDate);
            Assert.AreEqual(hotel.RegRecords[0].Resident.Phone, hotel.RegRecords[1].Resident.Phone);
            Assert.AreEqual(hotel.RegRecords[0].Resident.Email, hotel.RegRecords[1].Resident.Email);
        }
    }
}
