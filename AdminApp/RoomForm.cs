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
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"AdminApp\bin\Debug\");
        Hotel hotel;

        // Змінна з метою зберігання створюваного/переданого номера для подальшої перевірки.
        Room originalRoom;
        
        public RoomForm(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        public RoomForm(Hotel hotel, Room room) : this(hotel)
        {
            originalRoom = room;
            floorNumericUpDown.Enabled = false;
            numberNumericUpDown.Enabled = false;

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
            // Якщо змінна не містить значення (відбувається додавання нового номера),
            // то зробити перевірку на існування номера з заданами користувачем даними.
            if (originalRoom == null)
            {
                ValidateRoom(e);
            }
            ValidateImage(e);
        }

        private void ValidateImage(FormClosingEventArgs e)
        {
            if (imagePictureBox.Image == null)
            {
                MessageBox.Show("Вы не выбрали изображение!");
                e.Cancel = true;
            }
        }

        // Метод для перевірки, чи вже існує номер, який користувач бажає додати.
        private void ValidateRoom(FormClosingEventArgs e)
        {
            var room = hotel.FindRoom(
                Convert.ToInt32(floorNumericUpDown.Value),
                Convert.ToInt32(numberNumericUpDown.Value));
            if (room != null)
            {
                MessageBox.Show("Такой номер уже существует.");
                e.Cancel = true;
            }
        }
    }
}
