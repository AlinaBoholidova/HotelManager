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

namespace GuestApp
{
    // Форма гостьової панелі, де гість може додати свій відгук
    // або перейти до перегляду інших відгуків.
    //
    public partial class GuestPanel : Form
    {
        Hotel hotel;

        public GuestPanel()
        {
            InitializeComponent();
        }

        public GuestPanel(Hotel hotel) : this()
        {
            this.hotel = hotel;
        }

        private void GuestPanel_FormClosing(object sender, FormClosingEventArgs e)
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

        private void viewReviewsButton_Click(object sender, EventArgs e)
        {
            ReviewsPanel reviewsPanel = new ReviewsPanel(hotel);
            this.Hide();
            reviewsPanel.Show();
        }

        private void addReviewButton_Click(object sender, EventArgs e)
        {
            if (ValidateText(reviewTextBox))
            {
                Review review = new Review
                {
                    Guest = hotel.Guests.Last(),
                    Text = reviewTextBox.Text
                };
                hotel.AddReview(review);
                hotel.Save();

                ReviewsPanel reviewsPanel = new ReviewsPanel(hotel);
                this.Hide();
                reviewsPanel.Show();
            }
            else
            {
                reviewTextBox.Clear();
            }
        }

        // Метод для перевірки наявності тексту відгуку.
        private bool ValidateText(Control c)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                MessageBox.Show("Вы не написали отзыв!");
                return false;
            }
            return true;
        }
    }
}
