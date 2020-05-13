using HotelManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestApp
{
    public partial class GuestLogin : Form
    {
        Hotel hotel;
        public GuestLogin()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.Load();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidateName(nameTextBox) && ValidateDate(arrivalDateTimePicker, departureDateTimePicker))
            {
                Guest g = new Guest
                {
                    Name = nameTextBox.Text,
                    ArrivalDate = arrivalDateTimePicker.Value,
                    DepartureDate = departureDateTimePicker.Value
                };
                hotel.AddGuest(g);
                hotel.Save();
                this.Hide();
                GuestPanel guestPanel = new GuestPanel();
                guestPanel.Show();
            }
            else
            {
                nameTextBox.Clear();
                arrivalDateTimePicker.Value = DateTime.Today - TimeSpan.FromDays(1);
                departureDateTimePicker.Value = DateTime.Today;
            }
        }

        private bool ValidateName(Control c)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                MessageBox.Show("Неверно введённое имя.");
                return false;
            }
            return true;
        }

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
