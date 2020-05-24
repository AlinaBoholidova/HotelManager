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
        public static Hotel hotel;
        public AdminPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.FillTestData(25);
            roomBindingSource.DataSource = hotel.Rooms;
            residentBindingSource.DataSource = hotel.Residents;
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
            FillRegRecs();
            foreach (var r in hotel.Reviews)
            {
                reviewsTextBox.Text += r.Guest.Name + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.ArrivalDate + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.DepartureDate + Environment.NewLine;
                reviewsTextBox.Text += r.Text + Environment.NewLine + Environment.NewLine;
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
        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in regRecsGridView.Rows)
            {
                regRecsGridView.Rows[dr.Index].Visible = true;
            }
        }

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (paramComboBox.Text == "Имя")
                residentsDataGridView.DataSource = hotel.Residents.Where(x => x.Name == searchTextBox.Text).ToList();
            if (paramComboBox.Text == "Фамилия")
                residentsDataGridView.DataSource = hotel.Residents.Where(x => x.Surname == searchTextBox.Text).ToList();
            if (paramComboBox.Text == "Дата рождения")
                residentsDataGridView.DataSource = hotel.Residents.Where(x => x.BirthDate.Date == Convert.ToDateTime(searchTextBox.Text)).ToList();
        }

        private void renewButton_Click(object sender, EventArgs e)
        {
            paramComboBox.Text = "";
            searchTextBox.Clear();
            residentsDataGridView.DataSource = hotel.Residents;
        }

        private void addResidentButton_Click(object sender, EventArgs e)
        {
            if (hotel.IsFull())
            {
                MessageBox.Show("Hotel is full");
            }
            else
            {
                var rf = new RegRecForm();
                if (rf.ShowDialog() == DialogResult.OK)
                {
                    hotel.AddRegRec(rf.RegRecord);
                    roomBindingSource.ResetBindings(false);
                    regRecsGridView.Rows.Add($"{rf.RegRecord.Resident.Surname}", $"{rf.RegRecord.Resident.Name}",
                            $"{rf.RegRecord.Resident.Gender}", $"{rf.RegRecord.Resident.BirthDate.ToShortDateString()}",
                            $"{rf.RegRecord.Resident.Phone}", $"{rf.RegRecord.Resident.Email}",
                            $"{rf.RegRecord.Room.Floor}", $"{rf.RegRecord.Room.Number}",
                            $"{rf.RegRecord.ArrivalDate.ToShortDateString()}", $"{rf.RegRecord.DepartureDate.ToShortDateString()}",
                            $"{rf.RegRecord.Total}");
                    //Выбрать и перейти к последней строке
                    var lastIdx = regRecsGridView.Rows.Count - 1;
                    regRecsGridView.Rows[lastIdx].Selected = true;
                    regRecsGridView.FirstDisplayedScrollingRowIndex = lastIdx;
                }
            }

            }

        private void editResidentButton_Click(object sender, EventArgs e)
        {
            int ind = regRecsGridView.SelectedRows[0].Index;
            string surname = regRecsGridView.Rows[ind].Cells[0].Value.ToString();
            string phone = regRecsGridView.Rows[ind].Cells[4].Value.ToString();
            var toEdit = hotel.FindRegRec(surname, phone);
            var pf = new RegRecForm(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                regRecsGridView.Rows.Clear();
                FillRegRecs();
                regRecsGridView.Rows[ind].Selected = true;
                regRecsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
        }

        private void moveOutButton_Click(object sender, EventArgs e)
        {
            int ind = regRecsGridView.SelectedRows[0].Index;
            string surname = regRecsGridView.Rows[ind].Cells[0].Value.ToString();
            string phone = regRecsGridView.Rows[ind].Cells[4].Value.ToString();
            var toDel = hotel.FindRegRec(surname, phone);
            var mof = new MoveOutForm(toDel);
            if (mof.ShowDialog() == DialogResult.OK)
            {
                regRecsGridView.Rows.Clear();
                FillRegRecs();
                regRecsGridView.Rows[ind].Selected = true;
                regRecsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
            
        }

        public void FillRegRecs()
        {
            for (int i = 0; i < hotel.RegRecords.Count; i++)
            {
                regRecsGridView.Rows.Add($"{hotel.RegRecords[i].Resident.Surname}", $"{hotel.RegRecords[i].Resident.Name}",
                    $"{hotel.RegRecords[i].Resident.Gender}", $"{hotel.RegRecords[i].Resident.BirthDate.ToShortDateString()}",
                    $"{hotel.RegRecords[i].Resident.Phone}", $"{hotel.RegRecords[i].Resident.Email}",
                    $"{hotel.RegRecords[i].Room.Floor}", $"{hotel.RegRecords[i].Room.Number}",
                    $"{hotel.RegRecords[i].ArrivalDate.ToShortDateString()}", $"{hotel.RegRecords[i].DepartureDate.ToShortDateString()}",
                    $"{hotel.RegRecords[i].Total}");
            }
        }

        private void moveOutTodayButton_Click(object sender, EventArgs e)
        {
            int ind = regRecsGridView.SelectedRows[0].Index;
            string surname = regRecsGridView.Rows[ind].Cells[0].Value.ToString();
            string phone = regRecsGridView.Rows[ind].Cells[4].Value.ToString();
            var toDel = hotel.FindRegRec(surname, phone);
            var res = MessageBox.Show($"Выселить постояльца {toDel.Resident.Surname} {toDel.Resident.Name}?", "", 
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                hotel.RegRecords.Remove(toDel);
                roomBindingSource.ResetBindings(false);
                regRecsGridView.Rows.Clear();
                FillRegRecs();
            }
        }

        private void checkOutTodayButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Today.ToShortDateString();
            foreach (DataGridViewRow dr in regRecsGridView.Rows)
            {
                if (regRecsGridView.Rows[dr.Index].Cells[9].Value.ToString() == time)
                {
                    regRecsGridView.Rows[dr.Index].Visible = true;
                }
                else
                {
                    regRecsGridView.Rows[dr.Index].Visible = false;
                }
            }
        }
    }
}