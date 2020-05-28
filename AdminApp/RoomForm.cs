using HotelManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    // Форма для відображення основних даних про номер:
    // поверх, номер, зображення, ціна.
    //
    public partial class RoomForm : Form
    {
        Hotel hotel;
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"AdminApp\bin\Debug\");

        public RoomForm(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        public RoomForm(Hotel hotel, Room room) : this(hotel)
        {
            Room = room;
            floorNumericUpDown.Value = room.Floor;
            numberNumericUpDown.Value = room.Number;
            priceNumericUpDown.Value = room.Price;
            imagePictureBox.Image = room.Image;
        }

        public Room Room { set; get; }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            imageFileDialog.InitialDirectory = path;
            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = new Bitmap(imageFileDialog.FileName);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (Room == null)
            {
                Room = new Room();
            }
            Room.Floor = Convert.ToInt32(floorNumericUpDown.Value);
            Room.Number = Convert.ToInt32(numberNumericUpDown.Value);
            Room.Price = Convert.ToInt32(priceNumericUpDown.Value);
            Room.Image = imagePictureBox.Image;
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                return;
            }
            ValidateImage(imagePictureBox, e);
            ValidateRoom(floorNumericUpDown, numberNumericUpDown, e);
        }

        private void ValidateImage(PictureBox pb, FormClosingEventArgs e)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("Вы не выбрали изображение!");
                e.Cancel = true;
            }
        }

        private void ValidateRoom(NumericUpDown nud1, NumericUpDown nud2, FormClosingEventArgs e)
        {
            for (int i = 0; i < hotel.Rooms.Count; i++)
            {
                if (hotel.Rooms[i].Floor == nud1.Value && hotel.Rooms[i].Number == nud2.Value)
                {
                    MessageBox.Show("Такой номер уже существует.");
                    e.Cancel = true;
                }
            }
        }
    }
}
