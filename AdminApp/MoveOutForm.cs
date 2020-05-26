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
        Hotel hotel = AdminPanel.hotel;
        public static RegRecord RegRecord { set; get; }
        DateTime originalDD;
        //public bool notChanged;
        public MoveOutForm()
        {
            InitializeComponent();
        }

        public MoveOutForm(RegRecord regRecord) : this()
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

        //public void moveNowButton_Click(object sender, EventArgs e)
        //{
        //    var res = MessageBox.Show("Выселить постояльца?", "", MessageBoxButtons.OKCancel);
        //    if (res == DialogResult.OK)
        //    {
        //        button1.Visible = true;
        //        //hotel.RegRecords.Remove(RegRecord);
        //        //Room toFree = hotel.FindRoom(RegRecord.Room.Floor, RegRecord.Room.Number);
        //        //toFree.Occupied = false;
        //        //notChanged = false;
        //        //this.Close();
        //    }
        //}

        //private void moveEditButton_Click(object sender, EventArgs e)
        //{
        //    ChangeVisibility(moveNowButton);
        //    ChangeVisibility(arrivalDateTextBox);
        //    ChangeVisibility(arrivalDateLabel);
        //    ChangeVisibility(departureDateTimePicker);
        //    ChangeVisibility(departureDateLabel);
        //    ChangeVisibility(receiptButton);
        //    this.Update();
        //}

        //private void ChangeVisibility(Control toChange)
        //{
        //    toChange.Visible = !toChange.Visible;
        //}

        private void recalculationButton_Click(object sender, EventArgs e)
        {
            var toReceipt = RegRecord;
            var rf = new ReceiptForm(toReceipt);
            if (rf.ShowDialog() == DialogResult.OK)
            {
                button1.Visible = true;
                button3.Visible = false;
            }
        }

        private void departureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (departureDateTimePicker.Value != RegRecord.DepartureDate)
                recalculationButton.Visible = true;
            RegRecord.DepartureDate = departureDateTimePicker.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegRecord.DepartureDate = originalDD;
        }
    }
}
