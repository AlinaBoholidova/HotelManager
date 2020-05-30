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
    // Форма для перегляду відгуків готелю.
    //
    public partial class ReviewsPanel : Form
    {
        Hotel hotel;

        public ReviewsPanel()
        {
            InitializeComponent();
        }

        public ReviewsPanel(Hotel hotel) : this()
        {
            this.hotel = hotel;
        }

        private void ReviewsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Вы уверены, что оставили все отзывы?", "", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    Application.ExitThread();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void ReviewsPanel_Load(object sender, EventArgs e)
        {
            foreach (var r in hotel.Reviews)
            {
                reviewsTextBox.Text += r.Guest.Login + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.ArrivalDate.ToShortDateString() + Environment.NewLine;
                reviewsTextBox.Text += r.Guest.DepartureDate.ToShortDateString() + Environment.NewLine;
                reviewsTextBox.Text += r.Text + Environment.NewLine + Environment.NewLine;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            GuestPanel guestPanel = new GuestPanel(hotel);
            this.Hide();
            guestPanel.Show();
        }
    }
}
