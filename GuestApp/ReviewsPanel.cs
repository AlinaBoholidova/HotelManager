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

namespace GuestApp
{
    public partial class ReviewsPanel : Form
    {
        Hotel hotel;
        public ReviewsPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.Load();
        }

        private void ReviewsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReviewsPanel_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"AdminApp\bin\Debug\reviews.txt");
            string[] lines = File.ReadAllLines(path).Skip(2).ToArray();
            foreach (var line in lines)
            {
                textBox1.Text += line + Environment.NewLine;
            }

            //for (int i = 0; i < hotel.Reviews.Count; i++)
            //{
            //    textBox1.Text += hotel.Reviews[i].Guest.Name + '\r' + '\n';
            //    textBox1.Text += Convert.ToString(hotel.Reviews[i].Guest.ArrivalDate) + '\r' + '\n';
            //    textBox1.Text += Convert.ToString(hotel.Reviews[i].Guest.DepartureDate) + '\r' + '\n';
            //    textBox1.Text += hotel.Reviews[i].Text + '\r' + '\n';
            //    textBox1.Text += Environment.NewLine;
            //}
            //textBox1.Text = File.ReadAllText(path);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            GuestPanel guestPanel = new GuestPanel();
            guestPanel.Show();
            this.Hide();
        }

    }
}
