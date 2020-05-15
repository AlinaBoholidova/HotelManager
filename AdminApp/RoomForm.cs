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
    public partial class RoomForm : Form
    {
        public Room Room { set; get; }
        public RoomForm()
        {
            InitializeComponent();
        }

        public RoomForm(Room room) : this()
        {
            Room = room;
            typeComboBox.Text = room.Type;
            floorNumericUpDown.Value = room.Floor;
            numberNumericUpDown.Value = room.Number;
            priceNumericUpDown.Value = room.Price;
            imagePictureBox.Image = room.Image;
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (Room == null)
            {
                Room = new Room();
            }
            Room.Type = typeComboBox.Text;
            Room.Floor = Convert.ToInt32(floorNumericUpDown.Value);
            Room.Number = Convert.ToInt32(numberNumericUpDown.Value);
            Room.Price = Convert.ToInt32(priceNumericUpDown.Value);
            Room.Image = imagePictureBox.Image;
        }

        //private void NewRoom_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var r = new Room
        //    {
        //        Floor = (int)floorNumericUpDown.Value,
        //        Number = (int)numberNumericUpDown.Value,
        //        Price = (int)priceNumericUpDown.Value,
        //        ResidentsNumber = (int)residentsNumberNumericUpDown.Value,
        //        Type = typeComboBox.Text
        //    };
        //    Room = r;
        //}
    }
}
