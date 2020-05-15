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
    public partial class AdminLogin : Form
    {
        Hotel hotel;
        public AdminLogin()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.Load();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (ValidateData(nameTextBox, passwordTextBox))
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.welcomeLabel.Text = "Здравствуйте!\nВы вошли как " + this.nameTextBox.Text;
                this.Hide();
                adminPanel.Show();
            }
            else
            {
                nameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private bool ValidateData(Control c1, Control c2)
        {
            if (string.IsNullOrWhiteSpace(c1.Text) || string.IsNullOrWhiteSpace(c2.Text))
            {
                MessageBox.Show("Введите данные для входа.");
                return false;
            }
            else if (!FindAdmin(c1.Text, c2.Text))
            {
                MessageBox.Show("Нет администратора с такими данными.");
                return false;
            }
            else return true;
        }

        private bool FindAdmin(string name, string password)
        {
            foreach(var a in hotel.Admins)
            {
                if (a.Name == name && a.Password == password)
                    return true;
            }
            return false;
        }
    }
}
