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
    // Форма панелі адміністратора, весь функціонал якого розташований у вкладках:
    // список постояльців, список номерів, пошук, відгуки. Головна вкладка дозволяє
    // зберігати та завантажувати дані готелю; вкладка допомога - допомога користувачу.
    //
    public partial class AdminPanel : Form
    {
        Hotel hotel;

        public AdminPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.FillTestData(120);
            //hotel.FillData();
            roomBindingSource.DataSource = hotel.Rooms;
            residentBindingSource.DataSource = hotel.Residents;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hotel.IsDirty)
                Application.ExitThread();
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
                    Application.ExitThread();
                    break;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            FillRegRecs();
            FillReviews();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            hotel.Load();
            roomBindingSource.ResetBindings(false);
            regRecsGridView.Rows.Clear();
            FillRegRecs();
            reviewsTextBox.Clear();
            FillReviews();
            MessageBox.Show("Данные успешно загружены!");
        }

        private void FillReviews()
        {
            foreach (var r in hotel.Reviews)
            {
                reviewsTextBox.Text += r.Guest.Login + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.ArrivalDate.ToShortDateString() + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.DepartureDate.ToShortDateString() + Environment.NewLine;
                reviewsTextBox.Text += r.Text + Environment.NewLine + Environment.NewLine;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            hotel.Save();
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void addResidentButton_Click(object sender, EventArgs e)
        {
            if (hotel.IsFull())
            {
                MessageBox.Show("В отеле нет свободных номеров.");
            }
            else
            {
                var rf = new RegRecForm(hotel);
                if (rf.ShowDialog() == DialogResult.OK)
                {
                    hotel.AddRegRec(rf.RegRecord);
                    roomBindingSource.ResetBindings(false);
                    regRecsGridView.Rows.Add($"{rf.RegRecord.Resident.Surname}",
                                             $"{rf.RegRecord.Resident.Name}",
                                             $"{rf.RegRecord.Resident.Gender}",
                                             $"{rf.RegRecord.Resident.BirthDate.ToShortDateString()}",
                                             $"{rf.RegRecord.Resident.Phone}",
                                             $"{rf.RegRecord.Resident.Email}",
                                             $"{rf.RegRecord.Room.Floor}",
                                             $"{rf.RegRecord.Room.Number}",
                                             $"{rf.RegRecord.ArrivalDate.ToShortDateString()}",
                                             $"{rf.RegRecord.DepartureDate.ToShortDateString()}",
                                             $"{rf.RegRecord.Total}");
                    hotel.IsDirty = true;

                    // Обрати та перейти до останнього рядка.
                    var lastIdx = regRecsGridView.Rows.Count - 1;
                    regRecsGridView.Rows[lastIdx].Selected = true;
                    regRecsGridView.FirstDisplayedScrollingRowIndex = lastIdx;
                }
                //else
                //{
                //    roomBindingSource.ResetBindings(false);
                //    regRecsGridView.Rows.Clear();
                //    FillRegRecs();
                //}
            }
        }

        private void editResidentButton_Click(object sender, EventArgs e)
        {
            int ind = regRecsGridView.SelectedRows[0].Index;
            string surname = regRecsGridView.Rows[ind].Cells[0].Value.ToString();
            string phone = regRecsGridView.Rows[ind].Cells[4].Value.ToString();
            var toEdit = hotel.FindRegRec(surname, phone);
            var pf = new RegRecForm(hotel, toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
                regRecsGridView.Rows.Clear();
                FillRegRecs();
                hotel.IsDirty = true;

                regRecsGridView.Rows[ind].Selected = true;
                regRecsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
            //else
            //{
            //    regRecsGridView.Rows.Clear();
            //    FillRegRecs();
            //}
        }

        private void moveOutButton_Click(object sender, EventArgs e)
        {
            int ind = regRecsGridView.SelectedRows[0].Index;
            string surname = regRecsGridView.Rows[ind].Cells[0].Value.ToString();
            string phone = regRecsGridView.Rows[ind].Cells[4].Value.ToString();
            var toDel = hotel.FindRegRec(surname, phone);
            var mof = new MoveOutForm(hotel, toDel);
            if (mof.ShowDialog() == DialogResult.OK)
            {
                regRecsGridView.Rows.Clear();
                FillRegRecs();
                hotel.IsDirty = true;

                regRecsGridView.Rows[ind].Selected = true;
                regRecsGridView.FirstDisplayedScrollingRowIndex = ind;
            }
            //else
            //{
            //    regRecsGridView.Rows.Clear();
            //    FillRegRecs();
            //}
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
                hotel.RemoveRegRec(toDel);
                roomBindingSource.ResetBindings(false);
                regRecsGridView.Rows.Clear();
                FillRegRecs();
                hotel.IsDirty = true;
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in regRecsGridView.Rows)
            {
                regRecsGridView.Rows[dr.Index].Visible = true;
            }
            regRecsGridView.Rows[0].Selected = true;
            regRecsGridView.FirstDisplayedScrollingRowIndex = 0;
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
            regRecsGridView.Rows[0].Selected = true;
        }

        // Метод для заповнення DataGridView записів реєстрації даними готелю.
        private void FillRegRecs()
        {
            for (int i = 0; i < hotel.RegRecords.Count; i++)
            {
                regRecsGridView.Rows.Add($"{hotel.RegRecords[i].Resident.Surname}",
                                         $"{hotel.RegRecords[i].Resident.Name}",
                                         $"{hotel.RegRecords[i].Resident.Gender}",
                                         $"{hotel.RegRecords[i].Resident.BirthDate.ToShortDateString()}",
                                         $"{hotel.RegRecords[i].Resident.Phone}",
                                         $"{hotel.RegRecords[i].Resident.Email}",
                                         $"{hotel.RegRecords[i].Room.Floor}",
                                         $"{hotel.RegRecords[i].Room.Number}",
                                         $"{hotel.RegRecords[i].ArrivalDate.ToShortDateString()}",
                                         $"{hotel.RegRecords[i].DepartureDate.ToShortDateString()}",
                                         $"{hotel.RegRecords[i].Total}");
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (hotel.CheckFreeRooms())
            {
                var rf = new RoomForm(hotel);
                if (rf.ShowDialog() == DialogResult.OK)
                {
                    hotel.AddRoom(rf.Room);
                    roomBindingSource.ResetBindings(false);
                    hotel.IsDirty = true;

                    // Обрати та перейти до останнього рядка.
                    var lastIdx = roomGridView.Rows.Count - 1;
                    roomGridView.Rows[lastIdx].Selected = true;
                    roomGridView.FirstDisplayedScrollingRowIndex = lastIdx;
                }
            }
            else
            {
                MessageBox.Show("В отеле нет свободных для добавления номеров.");
            }
        }

        private void editRoomButton_Click(object sender, EventArgs e)
        {
            var toEdit = roomGridView.SelectedRows[0].DataBoundItem as Room;
            if (toEdit.Occupied == false)
            {
                var pf = new RoomForm(hotel, toEdit);
                if (pf.ShowDialog() == DialogResult.OK)
                {
                    roomBindingSource.ResetBindings(false);
                    hotel.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("Номер сейчас занят.");
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            var toDel = roomGridView.SelectedRows[0].DataBoundItem as Room;
            if (toDel.Occupied == false)
            {
                var res = MessageBox.Show($"Удалить номер {toDel.Number} этаж {toDel.Floor}?", "", 
                    MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    hotel.Rooms.Remove(toDel);
                    roomBindingSource.ResetBindings(false);
                    hotel.IsDirty = true;
                }
            }
            else
            {
                MessageBox.Show("Номер сейчас занят.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (paramComboBox.Text == "Имя")
                residentsDataGridView.DataSource = 
                    hotel.Residents.Where(x => x.Name == searchTextBox.Text).ToList();
            if (paramComboBox.Text == "Фамилия")
                residentsDataGridView.DataSource = 
                    hotel.Residents.Where(x => x.Surname == searchTextBox.Text).ToList();
            if (paramComboBox.Text == "Дата рождения")
                residentsDataGridView.DataSource = 
                    hotel.Residents.Where(x => x.BirthDate.Date == Convert.ToDateTime(searchTextBox.Text)).ToList();
        }

        // Метод для відображення усіх постояльців на вкладці пошуку.
        private void renewButton_Click(object sender, EventArgs e)
        {
            paramComboBox.Text = "";
            searchTextBox.Clear();
            residentsDataGridView.DataSource = hotel.Residents;
        }
    }
}