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

        Bitmap ca = new Bitmap(Path.GetFullPath("CityAbstraction.jpg")); //макс 2
        Bitmap ff = new Bitmap(Path.GetFullPath("FootballFan.jpg")); // макс 2
        Bitmap mf = new Bitmap(Path.GetFullPath("MorningFreshness.jpg")); // макс 3
        Bitmap rp = new Bitmap(Path.GetFullPath("RelaxingPurple.jpg")); // макс 2

        public void FillData()
        {
            // номера которые отсутствуют в отеле, их можно будет добавить пользователю
            //! номера которые участвуют в регистрациях, к ним вернуться и выставить actualresidents
            //- номера не участвуют в регистрациях и свободны для заселения, выставить occupied false
            // номера
            Rooms.Clear();
            // первый этаж
            //! 0 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 1, Price = 780, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 2, Price = 655, Image = ca });
            //! 1 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 3, Price = 1015, Image = ff });
            // 2 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 4, Price = 780, Image = ca });
            //! 3 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 5, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 6, Price = 1015, Image = ca });
            //! 4 Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 1, Number = 7, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 8, Price = 990, Image = rp });
            //! 5 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 9, Price = 605, Image = ff });
            //! 6 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 10, Price = 605, Image = rp });
            //! 7 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 11, Price = 1015, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 12, Price = 780, Image = ff });
            // 8 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 13, Price = 605, Image = mf });
            // 9 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 14, Price = 780, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 15, Price = 605, Image = ca });
            //! 10 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 16, Price = 1015, Image = ff });
            //! 11 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 17, Price = 655, Image = ff });
            //! 12 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 18, Price = 605, Image = mf });
            //! 13 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 19, Price = 1015, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 20, Price = 780, Image = ff });

            // второй этаж
            //! 14 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 2, Number = 1, Price = 990, Image = ff });
            //! 15 Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 2, Number = 2, Price = 605, Image = mf });
            //! 16 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 3, Price = 1015, Image = rp });
            //! 17 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 4, Price = 605, Image = ff });
            //! 18 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 5, Price = 780, Image = ca });
            //! 19 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 2, Number = 6, Price = 1015, Image = ff });
            // 20 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 7, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 8, Price = 605, Image = rp });
            // 21 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 9, Price = 1120, Image = ca });
            //! 22 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 10, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 11, Price = 1015, Image = ca });
            //! 23 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 12, Price = 1015, Image = ca });
            // 24 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 13, Price = 780, Image = ff });
            // 25 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 14, Price = 605, Image = mf });
            // 26 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 15, Price = 1120, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 16, Price = 605, Image = ca });
            //! 27 Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 2, Number = 17, Price = 990, Image = mf });
            // 28 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 18, Price = 1015, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 19, Price = 605, Image = ff });
            // 29 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 20, Price = 1120, Image = ff });

            // третий этаж
            // 30 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 1, Price = 1120, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 2, Price = 860, Image = mf });
            //! 31 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 3, Number = 3, Price = 655, Image = rp });
            //! 32 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 4, Price = 860, Image = ca });
            // 33 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 5, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 6, Price = 780, Image = rp });
            // 34 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 7, Price = 605, Image = mf });
            //! 35 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 3, Number = 8, Price = 860, Image = ca });
            // 36 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 9, Price = 605, Image = ca });
            // 37 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 10, Price = 780, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 11, Price = 860, Image = ff });
            //! 38 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 12, Price = 1120, Image = ca });
            // 39 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 13, Price = 605, Image = mf });
            // 40 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 14, Price = 655, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 15, Price = 860, Image = mf });
            // 41 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 16, Price = 1120, Image = rp });
            //! 42 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 17, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 18, Price = 740, Image = rp });
            // 43 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 19, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 20, Price = 780, Image = ca });

            // четвертый этаж
            //! 44 Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 4, Number = 1, Price = 1120, Image = mf });
            // 45 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 2, Price = 740, Image = ff });
            // 46 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 3, Price = 605, Image = rp });
            // 47 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 4, Price = 655, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 5, Price = 860, Image = ca });
            // 48 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 6, Price = 605, Image = ff });
            //! 49 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 7, Price = 935, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 8, Price = 740, Image = mf });
            // 50 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 9, Price = 860, Image = rp });
            //! 51 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 10, Price = 1120, Image = ca });
            // 52 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 11, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 12, Price = 860, Image = mf });
            //! 53 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 4, Number = 13, Price = 655, Image = ff });
            // 54 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 14, Price = 935, Image = mf });
            //! 55 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 15, Price = 605, Image = ca });
            // 56 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 16, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 17, Price = 740, Image = rp });
            // 57 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 18, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 19, Price = 655, Image = ff });
            //! 58 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 20, Price = 860, Image = ca });

            // пятый этаж
            // 59 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 1, Price = 935, Image = ff });
            //! 60 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 2, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 3, Price = 740, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 4, Price = 860, Image = ca });
            // 61 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 5, Price = 740, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 6, Price = 655, Image = rp });
            // 62 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 7, Price = 605, Image = ca });
            //! 63 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 8, Price = 935, Image = ff });
            // 64 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 9, Price = 655, Image = ca });
            // 65 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 10, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 11, Price = 935, Image = rp });
            //! 66 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 5, Number = 12, Price = 1120, Image = ca });
            // 67 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 13, Price = 860, Image = ff });
            // 68 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 14, Price = 740, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 15, Price = 655, Image = ca });
            //! 69 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 16, Price = 860, Image = ff });
            // 70 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 17, Price = 935, Image = ff });
            // 71 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 18, Price = 780, Image = rp });
            // 72 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 19, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 20, Price = 935, Image = ca });

            // шестой этаж
            // 73 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 1, Price = 740, Image = mf });
            //! 74 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 6, Number = 2, Price = 655, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 3, Price = 885, Image = ff });
            // 75 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 4, Price = 605, Image = rp });
            // 76 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 5, Price = 935, Image = ff });
            //! 77 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 6, Price = 860, Image = ca });
            // 78 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 7, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 8, Price = 655, Image = ca });
            // 79 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 9, Price = 860, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 10, Price = 1120, Image = ca });
            // 80 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 11, Price = 605, Image = ff });
            //! 81 Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 6, Number = 12, Price = 935, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 13, Price = 740, Image = ff });
            // 82 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 14, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 15, Price = 860, Image = rp });
            // 83 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 16, Price = 885, Image = rp });
            //! 84 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 17, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 18, Price = 935, Image = ff });
            //! 85 Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 19, Price = 740, Image = ca });
            // 86 Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 20, Price = 655, Image = ca });

            // первый этаж
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 1, Price = 780, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 2, Price = 655, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 3, Price = 1015, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 4, Price = 780, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 5, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 6, Price = 1015, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 1, Number = 7, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 8, Price = 990, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 9, Price = 605, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 10, Price = 605, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 11, Price = 1015, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 12, Price = 780, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 13, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 1, Number = 14, Price = 780, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 15, Price = 605, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 16, Price = 1015, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 17, Price = 655, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 1, Number = 18, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 1, Number = 19, Price = 1015, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 1, Number = 20, Price = 780, Image = ff });

            // второй этаж
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 2, Number = 1, Price = 990, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 2, Number = 2, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 3, Price = 1015, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 4, Price = 605, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 5, Price = 780, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 2, Number = 6, Price = 1015, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 7, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 8, Price = 605, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 9, Price = 1120, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 10, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 11, Price = 1015, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 2, Number = 12, Price = 1015, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 13, Price = 780, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 14, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 15, Price = 1120, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 16, Price = 605, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 2, Number = 17, Price = 990, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 18, Price = 1015, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 2, Number = 19, Price = 605, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 2, Number = 20, Price = 1120, Image = ff });

            // третий этаж
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 1, Price = 1120, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 2, Price = 860, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 3, Number = 3, Price = 655, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 4, Price = 860, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 5, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 6, Price = 780, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 7, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 3, Number = 8, Price = 860, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 9, Price = 605, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 10, Price = 780, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 11, Price = 860, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 12, Price = 1120, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 13, Price = 605, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 14, Price = 655, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 15, Price = 860, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 16, Price = 1120, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 3, Number = 17, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 18, Price = 740, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 3, Number = 19, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 3, Number = 20, Price = 780, Image = ca });

            // четвертый этаж
            Rooms.Add(new Room() { ActualResidents = 3, Occupied = true, Floor = 4, Number = 1, Price = 1120, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 2, Price = 740, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 3, Price = 605, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 4, Price = 655, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 5, Price = 860, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 6, Price = 605, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 7, Price = 935, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 8, Price = 740, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 9, Price = 860, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 10, Price = 1120, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 11, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 12, Price = 860, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 4, Number = 13, Price = 655, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 14, Price = 935, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 15, Price = 605, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 16, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 17, Price = 740, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 4, Number = 18, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 4, Number = 19, Price = 655, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 4, Number = 20, Price = 860, Image = ca });

            // пятый этаж
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 1, Price = 935, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 2, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 3, Price = 740, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 4, Price = 860, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 5, Price = 740, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 6, Price = 655, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 7, Price = 605, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 8, Price = 935, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 9, Price = 655, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 10, Price = 605, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 11, Price = 935, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 5, Number = 12, Price = 1120, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 13, Price = 860, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 14, Price = 740, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 15, Price = 655, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 5, Number = 16, Price = 860, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 17, Price = 935, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 18, Price = 780, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 5, Number = 19, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 5, Number = 20, Price = 935, Image = ca });

            // шестой этаж
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 1, Price = 740, Image = mf });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 6, Number = 2, Price = 655, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 3, Price = 885, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 4, Price = 605, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 5, Price = 935, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 6, Price = 860, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 7, Price = 605, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 8, Price = 655, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 9, Price = 860, Image = rp });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 10, Price = 1120, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 11, Price = 605, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 1, Occupied = true, Floor = 6, Number = 12, Price = 935, Image = ca });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 13, Price = 740, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 14, Price = 655, Image = mf });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 15, Price = 860, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 16, Price = 885, Image = rp });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 17, Price = 605, Image = ff });
            //Rooms.Add(new Room() { ActualResidents = 0, Occupied = true, Floor = 6, Number = 18, Price = 935, Image = ff });
            Rooms.Add(new Room() { ActualResidents = 2, Occupied = true, Floor = 6, Number = 19, Price = 740, Image = ca });
            Rooms.Add(new Room() { ActualResidents = 0, Occupied = false, Floor = 6, Number = 20, Price = 655, Image = ca });

            // постояльцы
            Residents.Clear();
            // 10
            Residents.Add(new Resident() { Surname = "Михайлов", Name = "Максим", Gender = "М", BirthDate = Convert.ToDateTime("18/03/1989"), Phone = "7573314", Email = "mikhaylov_max@gmail.com"});
            Residents.Add(new Resident() { Surname = "Zenger", Name = "Julian", Gender = "M", BirthDate = Convert.ToDateTime("26/08/1997"), Phone = "3186762", Email = "zenger@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Волков", Name = "Александр", Gender = "М", BirthDate = Convert.ToDateTime("14/02/1985"), Phone = "7651231", Email = "volkov@outlook.com" });
            Residents.Add(new Resident() { Surname = "Стрельцова", Name = "Евгения", Gender = "Ж", BirthDate = Convert.ToDateTime("26/11/1982"), Phone = "6874313", Email = "strelez@hotmail.com" });
            Residents.Add(new Resident() { Surname = "Hill", Name = "Kimberly", Gender = "Ж", BirthDate = Convert.ToDateTime("30/11/1989"), Phone = "1649837", Email = "kimberly.hill@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Смоляр", Name = "Артём", Gender = "М", BirthDate = Convert.ToDateTime("04/02/1986"), Phone = "8764532", Email = "smolyar.artem@ukr.net" });
            Residents.Add(new Resident() { Surname = "Бирюкова", Name = "Ольга", Gender = "Ж", BirthDate = Convert.ToDateTime("19/09/1994"), Phone = "9743211", Email = "biryukovao@mail.ua" });
            Residents.Add(new Resident() { Surname = "Tula", Name = "Samuel", Gender = "M", BirthDate = Convert.ToDateTime("24/07/1986"), Phone = "2435112", Email = "tula_samuel@gmail.com" });
            Residents.Add(new Resident() { Surname = "Кононов", Name = "Алексей", Gender = "М", BirthDate = Convert.ToDateTime("03/04/1998"), Phone = "8978942", Email = "kononov@hotmail.com" });
            Residents.Add(new Resident() { Surname = "Попова", Name = "Елизавета", Gender = "Ж", BirthDate = Convert.ToDateTime("05/06/1979"), Phone = "2354688", Email = "popova.elizabet@gmail.com" });

            // 20
            Residents.Add(new Resident() { Surname = "Сурмачевский", Name = "Андрей", Gender = "М", BirthDate = Convert.ToDateTime("22/06/1996"), Phone = "8745311", Email = "surmachevskii@gmail.com" });
            Residents.Add(new Resident() { Surname = "Акимова", Name = "Виктория", Gender = "Ж", BirthDate = Convert.ToDateTime("17/01/1966"), Phone = "7684651", Email = "akimova_victory@gmail.com" });
            Residents.Add(new Resident() { Surname = "Воронков", Name = "Фёдор", Gender = "М", BirthDate = Convert.ToDateTime("10/12/1995"), Phone = "7821519", Email = "voronkov.fedya@hotmail.com" });
            Residents.Add(new Resident() { Surname = "Фёдоров", Name = "Матвей", Gender = "М", BirthDate = Convert.ToDateTime("18/09/1974"), Phone = "9605144", Email = "fedorovmatv@ukr.net" });
            Residents.Add(new Resident() { Surname = "Jendryk", Name = "Jeffrey", Gender = "M", BirthDate = Convert.ToDateTime("15/09/1995"), Phone = "8907753", Email = "jendryk.jj@outlook.com" });
            Residents.Add(new Resident() { Surname = "Алекно", Name = "Владимир", Gender = "М", BirthDate = Convert.ToDateTime("11/11/1963"), Phone = "3328764", Email = "alekno@hotmail.com" });
            Residents.Add(new Resident() { Surname = "Королёва", Name = "Ирина", Gender = "Ж", BirthDate = Convert.ToDateTime("04/10/1990"), Phone = "8645133", Email = "koroleva90@ukr.net" });
            Residents.Add(new Resident() { Surname = "Adams", Name = "Rachael", Gender = "Ж", BirthDate = Convert.ToDateTime("03/06/1990"), Phone = "8781213", Email = "crazy.adams@outlook.com" });
            Residents.Add(new Resident() { Surname = "Кротков", Name = "Валентин", Gender = "М", BirthDate = Convert.ToDateTime("01/09/1991"), Phone = "9731771", Email = "krotkov.valya@ukr.net" });
            Residents.Add(new Resident() { Surname = "Павлова", Name = "Ольга", Gender = "Ж", BirthDate = Convert.ToDateTime("12/12/1962"), Phone = "6871321", Email = "pavlova62@gmail.com" });

            // 30
            Residents.Add(new Resident() { Surname = "Коновалова", Name = "Таисия", Gender = "Ж", BirthDate = Convert.ToDateTime("02/10/1986"), Phone = "6415321", Email = "konovalova@outlook.com" });
            Residents.Add(new Resident() { Surname = "Carlini", Name = "Lauren", Gender = "Ж", BirthDate = Convert.ToDateTime("28/02/1984"), Phone = "86768512", Email = "carlini.lauren@gmail.com" });
            Residents.Add(new Resident() { Surname = "Голубев", Name = "Валентин", Gender = "М", BirthDate = Convert.ToDateTime("03/05/1995"), Phone = "7643213", Email = "golubev0305@ukr.net" });
            Residents.Add(new Resident() { Surname = "Rivers", Name = "Krystal", Gender = "Ж", BirthDate = Convert.ToDateTime("23/05/1994"), Phone = "6974631", Email = "rivers94@outlook.com" });
            Residents.Add(new Resident() { Surname = "Фомина", Name = "Александра", Gender = "Ж", BirthDate = Convert.ToDateTime("02/12/1999"), Phone = "3645453", Email = "fomina.sasha@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Земчёнок", Name = "Денис", Gender = "М", BirthDate = Convert.ToDateTime("11/08/1987"), Phone = "6874321", Email = "zemchenok.denis@hotmail.com" });
            Residents.Add(new Resident() { Surname = "Романов", Name = "Алексей", Gender = "М", BirthDate = Convert.ToDateTime("22/02/2001"), Phone = "9743213", Email = "romanoff@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Lee", Name = "Simone", Gender = "Ж", BirthDate = Convert.ToDateTime("01/11/1977"), Phone = "9784531", Email = "lee.simone@outlook.com" });
            Residents.Add(new Resident() { Surname = "Алексеев", Name = "Сергей", Gender = "М", BirthDate = Convert.ToDateTime("15/05/1956"), Phone = "6547813", Email = "alekseev1505@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Соснов", Name = "Дмитрий", Gender = "М", BirthDate = Convert.ToDateTime("17/07/1975"), Phone = "5421356", Email = "sosnov.dmytro@gmail.com" });

            // 40
            Residents.Add(new Resident() { Surname = "Абрамова", Name = "Марина", Gender = "Ж", BirthDate = Convert.ToDateTime("02/09/1987"), Phone = "6784311", Email = "abramova.marina@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Чепенко", Name = "Полина", Gender = "Ж", BirthDate = Convert.ToDateTime("08/05/2002"), Phone = "3424878", Email = "polinka08@outlook.com" });
            Residents.Add(new Resident() { Surname = "Пояркова", Name = "Мария", Gender = "Ж", BirthDate = Convert.ToDateTime("17/11/1964"), Phone = "1268435", Email = "poyarkova1711@ukr.net" });
            Residents.Add(new Resident() { Surname = "Павленко", Name = "Олег", Gender = "М", BirthDate = Convert.ToDateTime("29/12/1978"), Phone = "1379416", Email = "oleg_pavlenko@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Кобзарь", Name = "Игорь", Gender = "М", BirthDate = Convert.ToDateTime("07/04/1991"), Phone = "8763133", Email = "kobzar.igor@gmail.com" });
            Residents.Add(new Resident() { Surname = "Тисевич", Name = "Николай", Gender = "М", BirthDate = Convert.ToDateTime("12/01/1981"), Phone = "7862313", Email = "tysevich.mykola@ukr.net" });
            Residents.Add(new Resident() { Surname = "Жигалов", Name = "Максим", Gender = "М", BirthDate = Convert.ToDateTime("14/09/1992"), Phone = "7923135", Email = "jhygalov92@yahoo.com" });
            Residents.Add(new Resident() { Surname = "Сорока", Name = "Анастасия", Gender = "Ж", BirthDate = Convert.ToDateTime("11/03/1983"), Phone = "6543318", Email = "soroka0311@outlook.com" });
            Residents.Add(new Resident() { Surname = "Воронин", Name = "Павел", Gender = "М", BirthDate = Convert.ToDateTime("26/07/1995"), Phone = "8731686", Email = "voronin95@gmail.com" });
            Residents.Add(new Resident() { Surname = "Кравченко", Name = "Наталья", Gender = "Ж", BirthDate = Convert.ToDateTime("01/04/1970"), Phone = "1589784", Email = "kravchenko.nataliia@ukr.net" });
            
            // записи регистраций
            RegRecords.Clear();
            // 10
            RegRecords.Add(new RegRecord(Rooms[0], Residents[0], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("02/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[55], Residents[1], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[49], Residents[2], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("03/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[14], Residents[3], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("06/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[16], Residents[4], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("12/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[11], Residents[5], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("07/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[81], Residents[6], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("10/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[15], Residents[7], Convert.ToDateTime("26/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[13], Residents[8], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("11/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[31], Residents[9], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("04/06/2020")));

            // 20
            RegRecords.Add(new RegRecord(Rooms[32], Residents[10], Convert.ToDateTime("26/05/2020"), Convert.ToDateTime("03/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[7], Residents[11], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("06/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[44], Residents[12], Convert.ToDateTime("26/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[10], Residents[13], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[12], Residents[14], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("07/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[23], Residents[15], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[6], Residents[16], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("11/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[22], Residents[17], Convert.ToDateTime("26/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[19], Residents[18], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("14/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[5], Residents[19], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("11/06/2020")));

            // 30
            RegRecords.Add(new RegRecord(Rooms[1], Residents[20], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("02/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[27], Residents[21], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[17], Residents[22], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("02/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[4], Residents[23], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("06/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[63], Residents[24], Convert.ToDateTime("26/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[66], Residents[25], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("08/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[3], Residents[26], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[18], Residents[27], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("08/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[53], Residents[28], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("07/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[77], Residents[29], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("05/06/2020")));

            // 40
            RegRecords.Add(new RegRecord(Rooms[35], Residents[30], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("15/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[38], Residents[31], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[42], Residents[32], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("07/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[51], Residents[33], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("04/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[58], Residents[34], Convert.ToDateTime("30/05/2020"), Convert.ToDateTime("01/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[60], Residents[35], Convert.ToDateTime("24/05/2020"), Convert.ToDateTime("31/05/2020")));
            RegRecords.Add(new RegRecord(Rooms[69], Residents[36], Convert.ToDateTime("29/05/2020"), Convert.ToDateTime("31/05/2020")));
            RegRecords.Add(new RegRecord(Rooms[74], Residents[37], Convert.ToDateTime("28/05/2020"), Convert.ToDateTime("05/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[84], Residents[38], Convert.ToDateTime("27/05/2020"), Convert.ToDateTime("02/06/2020")));
            RegRecords.Add(new RegRecord(Rooms[85], Residents[39], Convert.ToDateTime("25/05/2020"), Convert.ToDateTime("01/06/2020")));


            // гости
            Guests.Clear();
            Guests.Add(new Guest() { Login = "Вольвич Артём", ArrivalDate = Convert.ToDateTime("24/02/2020"), DepartureDate = Convert.ToDateTime("26/02/2020") });
            Guests.Add(new Guest() { Login = "Воропаев Дмитрий", ArrivalDate = Convert.ToDateTime("23/02/2020"), DepartureDate = Convert.ToDateTime("28/02/2020") });
            Guests.Add(new Guest() { Login = "Smith Tom", ArrivalDate = Convert.ToDateTime("18/02/2020"), DepartureDate = Convert.ToDateTime("29/02/2020") });
            Guests.Add(new Guest() { Login = "Никольченко Денис", ArrivalDate = Convert.ToDateTime("01/03/2020"), DepartureDate = Convert.ToDateTime("08/03/2020") });
            Guests.Add(new Guest() { Login = "Бутько Александр", ArrivalDate = Convert.ToDateTime("06/03/2020"), DepartureDate = Convert.ToDateTime("18/03/2020") });
            Guests.Add(new Guest() { Login = "Шишкин Михаил", ArrivalDate = Convert.ToDateTime("06/03/2020"), DepartureDate = Convert.ToDateTime("11/03/2020") });
            Guests.Add(new Guest() { Login = "Anderson Aaron", ArrivalDate = Convert.ToDateTime("08/03/2020"), DepartureDate = Convert.ToDateTime("11/03/2020") });
            Guests.Add(new Guest() { Login = "Вербов Алексей", ArrivalDate = Convert.ToDateTime("12/03/2020"), DepartureDate = Convert.ToDateTime("18/03/2020") });
            Guests.Add(new Guest() { Login = "Бабенко Светлана", ArrivalDate = Convert.ToDateTime("15/03/2020"), DepartureDate = Convert.ToDateTime("18/03/2020") });
            Guests.Add(new Guest() { Login = "Ахтырский Иван", ArrivalDate = Convert.ToDateTime("16/03/2020"), DepartureDate = Convert.ToDateTime("22/03/2020") });
            Guests.Add(new Guest() { Login = "Твёрдая Мария", ArrivalDate = Convert.ToDateTime("19/03/2020"), DepartureDate = Convert.ToDateTime("22/03/2020") });
            Guests.Add(new Guest() { Login = "Baker Sophia", ArrivalDate = Convert.ToDateTime("22/03/2020"), DepartureDate = Convert.ToDateTime("23/03/2020") });
            Guests.Add(new Guest() { Login = "Воробьёва Светлана", ArrivalDate = Convert.ToDateTime("24/03/2020"), DepartureDate = Convert.ToDateTime("03/04/2020") });
            Guests.Add(new Guest() { Login = "Никитин Сергей", ArrivalDate = Convert.ToDateTime("03/04/2020"), DepartureDate = Convert.ToDateTime("08/04/2020") });
            Guests.Add(new Guest() { Login = "Кадькало Эвелина", ArrivalDate = Convert.ToDateTime("31/03/2020"), DepartureDate = Convert.ToDateTime("11/04/2020") });
            Guests.Add(new Guest() { Login = "Бубликов Николай", ArrivalDate = Convert.ToDateTime("01/04/2020"), DepartureDate = Convert.ToDateTime("12/04/2020") });
            Guests.Add(new Guest() { Login = "Dixon Alan", ArrivalDate = Convert.ToDateTime("07/04/2020"), DepartureDate = Convert.ToDateTime("14/04/2020") });
            Guests.Add(new Guest() { Login = "Михайлова Владислава", ArrivalDate = Convert.ToDateTime("15/04/2020"), DepartureDate = Convert.ToDateTime("18/04/2020") });
            Guests.Add(new Guest() { Login = "Ященко Максим", ArrivalDate = Convert.ToDateTime("21/04/2020"), DepartureDate = Convert.ToDateTime("28/04/2020") });
            Guests.Add(new Guest() { Login = "Попова София", ArrivalDate = Convert.ToDateTime("05/05/2020"), DepartureDate = Convert.ToDateTime("09/05/2020") });

            // отзывы
            Reviews.Clear();
            Reviews.Add(new Review() { Guest = Guests[0], Text = "Приехали с командой в город на игру. Не пожалели, что " +
                "выбрали этот отель, ведь мы отлично отдохнули от дороги и победили!" });
            Reviews.Add(new Review() { Guest = Guests[1], Text = "Отель очень порадовал качеством обслуживания. Видно, что гость " +
                "здесь в приоритете." });
            Reviews.Add(new Review() { Guest = Guests[2], Text = "I am very surprised with hotel service! Even though I'm not " +
                "very good in Russian, administrator Sergey understood me pretty well!" });
            Reviews.Add(new Review() { Guest = Guests[3], Text = "Благодаря отелю отлично порадовал своих девчонок на их женской неделе!" });
            Reviews.Add(new Review() { Guest = Guests[4], Text = "Превосходно провели время в городе, затянув празднование Дня " +
                "рождения, в чём много поспособствовал отель!" });
            Reviews.Add(new Review() { Guest = Guests[5], Text = "В целом остались довольными услугами, но можно было бы улучшить питание." });
            Reviews.Add(new Review() { Guest = Guests[6], Text = "It was my first time in Ukraine and I can say that this new hotel " +
                "experience was astonishing!" });
            Reviews.Add(new Review() { Guest = Guests[7], Text = "Отлично провели культурный отпуск вместе с семьёй :)" });
            Reviews.Add(new Review() { Guest = Guests[8], Text = "Отель прекрасно подходит для отдыха с маленькими детьми" });
            Reviews.Add(new Review() { Guest = Guests[9], Text = "В отеле оказались очень внимательными к людям с " +
                "ограниченными возможностями, что очень порадовало." });
            Reviews.Add(new Review() { Guest = Guests[10], Text = "Стоит тщательнее готовить номера к заселению новых постояльцев." });
            Reviews.Add(new Review() { Guest = Guests[11], Text = "I needed a hotel just for one night, but I'll remember that night forever!" });
            Reviews.Add(new Review() { Guest = Guests[12], Text = "Неприятно было обнаружить измятую кровать при поселении." });
            Reviews.Add(new Review() { Guest = Guests[13], Text = "В отеле не хватает бесплатной воды в номерах." });
            Reviews.Add(new Review() { Guest = Guests[14], Text = "Вовремя следят за чистотой номера!" });
            Reviews.Add(new Review() { Guest = Guests[15], Text = "Администраторы очень приветливые и отзывчивые, выполнят любую просьбу!" });
            Reviews.Add(new Review() { Guest = Guests[16], Text = "The best hotel experience in my life!" });
            Reviews.Add(new Review() { Guest = Guests[17], Text = "Отлично провели затянувшийся девичник :)" });
            Reviews.Add(new Review() { Guest = Guests[18], Text = "Хотелось бы увидеть более разнообразное питание." });
            Reviews.Add(new Review() { Guest = Guests[19], Text = "Всё настолько понравилось, что даже и забыла, что находилась в командировке!" });
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
                RegRecords.Add(new RegRecord(Rooms[i], Residents[i], DateTime.Today, 
                    DateTime.Today + TimeSpan.FromDays(i + 1))); // затестить с таким

                //RegRecords.Add(new RegRecord(new Room()
                //{
                //    ActualResidents = 1,
                //    Floor = (i % 6) + 1,
                //    Number = (i % 20) + 1,
                //    Price = i + 600,
                //    Image = noImage,
                //    Occupied = true
                //}
                //, new Resident()
                //{
                //    Surname = $"ResidentSurname{i}",
                //    Name = $"ResidentName{i}",
                //    BirthDate = DateTime.Today - TimeSpan.FromDays(i + 1),
                //    Gender = "-",
                //    Phone = "123456789",
                //    Email = "example@gmail.com"
                //},
                //DateTime.Today,
                //DateTime.Today + TimeSpan.FromDays(i + 1)));
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
                    Guest = Guests[i], // затестить с таким вариантом
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