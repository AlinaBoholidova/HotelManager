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
    public partial class AdminPanel : Form
    {
        Hotel hotel;
        public AdminPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.FillTestData(50);
            roomBindingSource.DataSource = hotel.Rooms;
            //bindingSource1.DataSource = hotel.Reviews;
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
            //bindingSource1.ResetBindings(false);
            dataGridView2.Columns.Add("Name", "Имя");
            dataGridView2.Columns.Add("ArrivalDate", "Дата заселения");
            dataGridView2.Columns.Add("DepartureDate", "Дата выселения");
            dataGridView2.Columns.Add("ReviewText", "Текст");

            for (int i = 0; i < hotel.Reviews.Count; ++i)
            {
                dataGridView2.Rows.Add($"{hotel.Guests[i].Name}", $"{hotel.Guests[i].ArrivalDate}",
                    $"{hotel.Guests[i].DepartureDate}", $"{hotel.Reviews[i].Text}");
            }
        }

        private void newNumberButton_Click(object sender, EventArgs e)
        {
            var nr = new RoomForm();
            if (nr.ShowDialog() == DialogResult.OK)
            {
                hotel.Rooms.Add(nr.Room);
                roomBindingSource.ResetBindings(false);
            }
        }

    }
}