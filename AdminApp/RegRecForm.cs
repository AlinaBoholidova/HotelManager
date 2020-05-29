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

namespace AdminApp
{
    // Форма для заповнення/відображення даних запису реєстрації.
    //
    public partial class RegRecForm : Form
    {
        Hotel hotel;

        // Змінна, яка зберігає запис реєстрації, переданий на форму, у випадку
        // відміни його редагування.
        RegRecord originalRegRecord;

        // Змінна, яка зберігає номер, переданий на форму, для перевірки переселення
        // постояльця до іншого номера.
        Room originalRoom;

        public RegRecForm(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
            arrivalDateTimePicker.MaxDate = DateTime.Today;
            departureDateTimePicker.MinDate = DateTime.Today + TimeSpan.FromDays(1);
        }

        // Конструктор для передачі даних запису реєстрації для редагування.
        public RegRecForm(Hotel hotel, RegRecord regRecord) : this(hotel)
        {
            originalRegRecord = new RegRecord() { Resident = new Resident(), Room = new Room() };
            originalRegRecord.CopyData(originalRegRecord, regRecord);
            originalRoom = regRecord.Room;

            RegRecord = regRecord;
            arrivalDateTimePicker.Value = regRecord.ArrivalDate;
            departureDateTimePicker.Value = regRecord.DepartureDate;
            surnameTextBox.Text = regRecord.Resident.Surname;
            nameTextBox.Text = regRecord.Resident.Name;
            genderComboBox.Text = regRecord.Resident.Gender;
            birthDateTimePicker.Value = regRecord.Resident.BirthDate;
            phoneTextBox.Text = regRecord.Resident.Phone;
            emailTextBox.Text = regRecord.Resident.Email;
            typeComboBox.Text = regRecord.Room.Type;
            floorComboBox.Text = Convert.ToString(regRecord.Room.Floor);
            numberComboBox.Text = Convert.ToString(regRecord.Room.Number);
            actualResidentsNumericUpDown.Value = regRecord.Room.ActualResidents;
            totalLabel.Text = Convert.ToString(regRecord.Total);
            
            arrivalDateTimePicker.Enabled = false;
            departureDateTimePicker.Enabled = false;
            actualResidentsNumericUpDown.Enabled = false;
        }

        public RegRecord RegRecord { set; get; }
        
        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    if (RegRecord == null)
                    {
                        RegRecord = new RegRecord() { Resident = new Resident() };
                    }

                    var room = hotel.FindRoom(
                        Convert.ToInt32(floorComboBox.Text),
                        Convert.ToInt32(numberComboBox.Text));

                    // Перевірка, чи був переселений постоялець до іншого номеру.
                    if (originalRoom != null && originalRoom != room)
                    {
                        originalRoom.Occupied = false;
                        originalRoom.ActualResidents = 0;
                    }

                    RegRecord.ArrivalDate = arrivalDateTimePicker.Value;
                    RegRecord.DepartureDate = departureDateTimePicker.Value;
                    RegRecord.Room = room;
                    RegRecord.Room.Occupied = true;
                    RegRecord.Room.ActualResidents = Convert.ToInt32(actualResidentsNumericUpDown.Value);
                    RegRecord.Resident.Surname = surnameTextBox.Text;
                    RegRecord.Resident.Name = nameTextBox.Text;
                    RegRecord.Resident.Gender = genderComboBox.Text;
                    RegRecord.Resident.BirthDate = birthDateTimePicker.Value;
                    RegRecord.Resident.Phone = phoneTextBox.Text;
                    RegRecord.Resident.Email = emailTextBox.Text;
                    
                    var toReceipt = RegRecord;
                    var rf = new ReceiptForm(toReceipt);
                    if (rf.ShowDialog() == DialogResult.OK)
                    {
                        saveButton.Enabled = true;
                        backButton.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorComboBox.Items.Clear();
            numberComboBox.Items.Clear();
            List<int> floor = new List<int>();
            for (int i = 0; i < hotel.Rooms.Count; i++)
            {
                if (hotel.Rooms[i].Type == typeComboBox.Text)
                {
                    floor.Add(hotel.Rooms[i].Floor);
                }
            }
            IEnumerable<int> dfloor = floor.Distinct();
            foreach (var f in dfloor)
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

        private void numberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = hotel.FindRoom(
                Convert.ToInt32(floorComboBox.Text), 
                Convert.ToInt32(numberComboBox.Text));
            actualResidentsNumericUpDown.Maximum = room.InitialResidents;
        }

        // Метод для перевірки правильності вводу даних.
        private bool ValidateData()
        {
            if (!Regex.IsMatch(nameTextBox.Text, @"[а-яА-Яa-zA-Z]{2}"))
            {
                MessageBox.Show("Неправильно введённое имя.");
                return false;
            }
            if (!Regex.IsMatch(surnameTextBox.Text, @"[а-яА-Яa-zA-Z]{2}"))
            {
                MessageBox.Show("Неправильно введённая фамилия.");
                return false;
            }
            if (genderComboBox.Text == "")
            {
                RegRecord.Resident.Gender = "-";
            }
            if (birthDateTimePicker.Value.AddYears(18) > DateTime.Today.Date)
            {
                MessageBox.Show("Нельзя оформить номер на несовершеннолетнего.");
                return false;
            }
            if (!Regex.IsMatch(phoneTextBox.Text, @"[0-9]{7}"))
            {
                MessageBox.Show("Телефон должен состоять только из цифр и не быть коротким.");
                return false;
            }
            if (!Regex.IsMatch(emailTextBox.Text, @"[a-zA-Z0-9]{2}[@][a-zA-Z]{2}"))
            {
                MessageBox.Show("Email не содержит символ @ или он слишком короткий.");
                return false;
            }
            return true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // У випадку відміни редагування номера повернути початкові дані запису реєстрації.
            if (originalRegRecord != null)
            {
                RegRecord.Room.Occupied = false;
                RegRecord.Room.ActualResidents = 0;
                RegRecord.CopyData(RegRecord, originalRegRecord);
                originalRoom.Occupied = true;
                originalRoom.ActualResidents = originalRegRecord.Room.ActualResidents;
            }
            originalRoom = hotel.FindRoom(
                Convert.ToInt32(floorComboBox.Text),
                Convert.ToInt32(numberComboBox.Text));
            originalRoom.Occupied = false;
            originalRoom.ActualResidents = 0;
        }
    }
}
