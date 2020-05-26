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
    public partial class GuestPanel : Form
    {
        Hotel hotel;
        public GuestPanel()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.Load();
        }

        //public GuestPanel(Hotel hotel)
        //{
        //    this.hotel = hotel;
        //    InitializeComponent();
        //}

        private void GuestPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonViewReviews_Click(object sender, EventArgs e)
        {
            ReviewsPanel reviewsPanel = new ReviewsPanel();
            reviewsPanel.Show();
            this.Hide();
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            if (ValidateText(reviewTextBox))
            {
                //string text = "";
                //for (int i = 0; i < textBoxReview.Lines.Length; i++)
                //{
                //    text += textBoxReview.Lines[i] + "\n";
                //}
                Review review = new Review
                {
                    Guest = hotel.Guests.Last(),
                    Text = reviewTextBox.Text
                };
                hotel.AddReview(review);
                hotel.Save();
                ReviewsPanel reviewsPanel = new ReviewsPanel();
                reviewsPanel.Show();
                this.Hide();
            }
            else
            {
                reviewTextBox.Clear();
            }
        }

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
