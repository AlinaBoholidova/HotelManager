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
    public partial class RegRecForm : Form
    {
        Hotel hotel = AdminPanel.hotel;
        public RegRecord RegRecord { set; get; }
        public RegRecForm()
        {
            InitializeComponent();
        }

        public RegRecForm(RegRecord regRecord) : this()
        {
            RegRecord = regRecord;
            surnameTextBox.Text = regRecord.Resident.Surname;
            nameTextBox.Text = regRecord.Resident.Name;
            genderComboBox.Text = regRecord.Resident.Gender;
            birthDateTimePicker.Value = regRecord.Resident.BirthDate;
            phoneTextBox.Text = regRecord.Resident.Phone;
            emailTextBox.Text = regRecord.Resident.Email;
            floorComboBox.Text = Convert.ToString(regRecord.Room.Floor);
            numberComboBox.Text = Convert.ToString(regRecord.Room.Number);
            typeComboBox.Text = regRecord.Room.Type;
            arrivalDateTimePicker.Value = regRecord.ArrivalDate;
            departureDateTimePicker.Value = regRecord.DepartureDate;
            totalLabel1.Text = Convert.ToString(regRecord.Total);
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            int floor = Convert.ToInt32(floorComboBox.Text);
            int number = Convert.ToInt32(numberComboBox.Text);
            Room room = hotel.FindRoom(floor, number);
            room.ActualResidents = Convert.ToInt32(actualResidentsNumericUpDown.Value);
            Resident resident = new Resident()
            {
                Surname = surnameTextBox.Text,
                Name = nameTextBox.Text,
                Gender = genderComboBox.Text,
                BirthDate = birthDateTimePicker.Value,
                Phone = phoneTextBox.Text,
                Email = emailTextBox.Text
            };
            DateTime adate = arrivalDateTimePicker.Value;
            DateTime ddate = departureDateTimePicker.Value;
            if (RegRecord == null)
            {
                RegRecord = new RegRecord(room, resident, adate, ddate);
            }
            Room temp = hotel.FindRoom(floor, number);
            RegRecord.Room.ActualResidents = Convert.ToInt32(actualResidentsNumericUpDown.Value);
            RegRecord.Room.Floor = temp.Floor;
            RegRecord.Room.Number = temp.Number;
            RegRecord.Room.Image = temp.Image;
            RegRecord.Room.Id = temp.Id;
            RegRecord.Room.Price = temp.Price;
            RegRecord.Resident.Surname = surnameTextBox.Text;
            RegRecord.Resident.Name = nameTextBox.Text;
            RegRecord.Resident.Gender = genderComboBox.Text;
            RegRecord.Resident.BirthDate = birthDateTimePicker.Value;
            RegRecord.Resident.Phone = phoneTextBox.Text;
            RegRecord.Resident.Email = emailTextBox.Text;
            RegRecord.ArrivalDate = adate;
            RegRecord.DepartureDate = ddate;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorComboBox.Items.Clear();
            List<int> floor = new List<int>();
            for (int i = 0; i < hotel.Rooms.Count; i++)
            {
                if (hotel.Rooms[i].Type == typeComboBox.Text)
                {
                    floor.Add(hotel.Rooms[i].Floor);
                }
            }
            IEnumerable<int> dfloor = floor.Distinct();
            foreach(var f in dfloor)
            {
                floorComboBox.Items.Add(f.ToString());
            }
        }

        private void floorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberComboBox.Items.Clear();
            for (int i = 0; i < hotel.Rooms.Count; i++)
            {
                if (hotel.Rooms[i].Floor == Convert.ToInt32(floorComboBox.Text) &&
                    hotel.Rooms[i].Occupied == false &&
                    hotel.Rooms[i].ActualResidents != hotel.Rooms[i].InitialResidents)
                {
                    numberComboBox.Items.Add(hotel.Rooms[i].Number.ToString());
                }
            }
        }
    }
}
