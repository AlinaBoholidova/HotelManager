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

namespace AdminApp
{
    public partial class MoveOutForm : Form
    {
        Hotel hotel;
        RegRecord RegRecord { set; get; }
        DateTime originalDD;
        public MoveOutForm(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        public MoveOutForm(Hotel hotel, RegRecord regRecord) : this(hotel)
        {
            RegRecord = regRecord;
            surnameLabel.Text = regRecord.Resident.Surname;
            nameLabel.Text = regRecord.Resident.Name;
            genderLabel.Text = regRecord.Resident.Gender;
            birthDateLabel.Text = regRecord.Resident.BirthDate.ToShortDateString();
            phoneLabel.Text = regRecord.Resident.Phone;
            emailLabel.Text = regRecord.Resident.Email;
            floorLabel.Text = Convert.ToString(regRecord.Room.Floor);
            numberLabel.Text = Convert.ToString(regRecord.Room.Number);
            typeLabel.Text = regRecord.Room.Type;
            arrivalDateLabel.Text = regRecord.ArrivalDate.ToShortDateString();
            departureDateTimePicker.Value = regRecord.DepartureDate;
            originalDD = regRecord.DepartureDate;
        }

        private void recalculationButton_Click(object sender, EventArgs e)
        {
            var toReceipt = RegRecord;
            var rf = new ReceiptForm(toReceipt);
            if (rf.ShowDialog() == DialogResult.OK)
            {
                saveButton.Enabled = true;
                backButton.Enabled = false;
            }
        }

        private void departureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (departureDateTimePicker.Value != RegRecord.DepartureDate)
            {
                recalculationButton.Enabled = true;
            }
            RegRecord.DepartureDate = departureDateTimePicker.Value;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RegRecord.DepartureDate = originalDD;
        }
    }
}
