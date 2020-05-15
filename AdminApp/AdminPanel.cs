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
            foreach (var r in hotel.Reviews)
            {
                reviewsTextBox.Text += r.Guest.Name + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.ArrivalDate + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.DepartureDate + Environment.NewLine;
                reviewsTextBox.Text += r.Text + Environment.NewLine + Environment.NewLine;
            }

            regRecsGridView.Columns.Add("Surname", "Фамилия");
            regRecsGridView.Columns.Add("Name", "Имя");
            regRecsGridView.Columns.Add("Gender", "Пол");
            regRecsGridView.Columns.Add("BirthDate", "Дата рождения");
            regRecsGridView.Columns.Add("Phone", "Телефон");
            regRecsGridView.Columns.Add("Email", "Эл.почта");
            regRecsGridView.Columns.Add("Floor", "Этаж");
            regRecsGridView.Columns.Add("Number", "Номер");
            regRecsGridView.Columns.Add("ArrivalDate", "Дата приезда");
            regRecsGridView.Columns.Add("DepartureDate", "Дата отъезда");
            regRecsGridView.Columns.Add("Total", "Сумма к оплате");

            for (int i = 0; i < hotel.RegRecords.Count; i++)
            {
                regRecsGridView.Rows.Add($"{hotel.RegRecords[i].Resident.Surname}", $"{hotel.RegRecords[i].Resident.Name}",
                    $"{hotel.RegRecords[i].Resident.Gender}", $"{hotel.RegRecords[i].Resident.BirthDate}", 
                    $"{hotel.RegRecords[i].Resident.Phone}", $"{hotel.RegRecords[i].Resident.Email}",
                    $"{hotel.RegRecords[i].Room.Floor}", $"{hotel.RegRecords[i].Room.Number}", 
                    $"{hotel.RegRecords[i].ArrivalDate}", $"{hotel.RegRecords[i].DepartureDate}", $"{hotel.RegRecords[i].Total}");
            }
            //hotel.Load();
            //roomBindingSource.ResetBindings(false);
            //bindingSource1.ResetBindings(false);
            //dataGridView2.Columns.Add("Name", "Имя");
            //dataGridView2.Columns.Add("ArrivalDate", "Дата заселения");
            //dataGridView2.Columns.Add("DepartureDate", "Дата выселения");
            //dataGridView2.Columns.Add("ReviewText", "Текст");

            //for (int i = 0; i < hotel.Reviews.Count; ++i)
            //{
            //    dataGridView2.Rows.Add($"{hotel.Guests[i].Name}", $"{hotel.Guests[i].ArrivalDate}",
            //        $"{hotel.Guests[i].DepartureDate}", $"{hotel.Reviews[i].Text}");
            //}
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            hotel.Load();
            roomBindingSource.ResetBindings(false);
            string[] lines = File.ReadAllLines("reviews.txt").Skip(2).ToArray();
            foreach (var line in lines)
            {
                reviewsTextBox.Text += line + Environment.NewLine;
            }
            MessageBox.Show("Данные успешно загружены!");
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            var rf = new RoomForm();
            if (rf.ShowDialog() == DialogResult.OK)
            {
                hotel.AddRoom(rf.Room);
                roomBindingSource.ResetBindings(false);

                //Выбрать и перейти к последней строке
                var lastIdx = roomGridView.Rows.Count - 1;
                roomGridView.Rows[lastIdx].Selected = true;
                roomGridView.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editRoomButton_Click(object sender, EventArgs e)
        {
            var toEdit = roomGridView.SelectedRows[0].DataBoundItem as Room;
            var pf = new RoomForm(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            var toDel = roomGridView.SelectedRows[0].DataBoundItem as Room;
            var res = MessageBox.Show($"Удалить номер {toDel.Number} этаж {toDel.Floor}?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                hotel.Rooms.Remove(toDel);
                roomBindingSource.ResetBindings(false);
            }
        }
    }
}