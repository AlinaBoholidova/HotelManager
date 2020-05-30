using HotelManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestApp
{
    // Форма для персоніфікації звичайного користувача (гостя), де
    // вводяться ім'я, дати приїзду та від'їзду, і за коректності вводу
    // відбувається перехід на гостьову панель.
    //
    public partial class GuestLogin : Form
    {
        Hotel hotel;

        public GuestLogin()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.Load();

            arrivalDateTimePicker.MaxDate = DateTime.Today - TimeSpan.FromDays(1);
            departureDateTimePicker.MaxDate = DateTime.Today;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateName(nameTextBox) && ValidateDate(arrivalDateTimePicker, departureDateTimePicker))
            {
                Guest g = new Guest
                {
                    Login = nameTextBox.Text,
                    ArrivalDate = arrivalDateTimePicker.Value,
                    DepartureDate = departureDateTimePicker.Value
                };
                hotel.AddGuest(g);
                hotel.Save();

                GuestPanel guestPanel = new GuestPanel(hotel);
                this.Hide();
                guestPanel.Show();
            }
            else
            {
                nameTextBox.Clear();
                arrivalDateTimePicker.Value = DateTime.Today - TimeSpan.FromDays(1);
                departureDateTimePicker.Value = DateTime.Today;
            }
        }

        // Перевірка поля прізвища-імені на заповненість.
        private bool ValidateName(Control c)
        {
            if (!Regex.IsMatch(c.Text, @"^[а-яА-Яa-zA-Z\s]{5,}$"))
            {
                MessageBox.Show("Неверные символы или фамилия-имя слишком короткие (мин. 5 символов в поле).");
                return false;
            }
            return true;
        }

        // Перевірка полей дат приїзду та від'їзду (різниця хоча б один день).
        private bool ValidateDate(Control c1, Control c2)
        {
            DateTimePicker dtp1 = c1 as DateTimePicker;
            DateTimePicker dtp2 = c2 as DateTimePicker;
            if (dtp1.Value > dtp2.Value || dtp1.Value == dtp2.Value)
            {
                MessageBox.Show("Неверно введённые даты.");
                return false;
            }
            return true;
        }
    }
}
