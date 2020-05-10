using HotelManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class AdminPanel : Form
    {
        Hotel hotel;
        public AdminPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.FillTestData(50);
            roomBindingSource.DataSource = hotel.Rooms;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Сохранить данные перед выходом?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    hotel.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            hotel.Load();
            roomBindingSource.ResetBindings(false);
        }

        private void newNumberButton_Click(object sender, EventArgs e)
        {
            var nr = new NewRoom();
            if (nr.ShowDialog() == DialogResult.OK)
            {
                hotel.Rooms.Add(nr.Room);
                roomBindingSource.ResetBindings(false);
            }
        }
    }
}