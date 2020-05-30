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
    // Форма для персоніфікації гостя при вході у програму, де вводяться ім'я,
    // дати приїзду та від'їзду.
    //
    public partial class AdminLogin : Form
    {
        Hotel hotel;

        public AdminLogin()
        {
            InitializeComponent();
            hotel = new Hotel();
            hotel.ConnectAdmins();
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

        // Метод для перевірки полей: непорожні і
        // у системі готелю є адміністратор з такими даними.
        private bool ValidateData(Control c1, Control c2)
        {
            if (string.IsNullOrWhiteSpace(c1.Text) || string.IsNullOrWhiteSpace(c2.Text))
            {
                MessageBox.Show("Введите данные для входа.");
                return false;
            }
            else if (!hotel.FindAdmin(c1.Text, c2.Text))
            {
                MessageBox.Show("Нет администратора с такими данными.");
                return false;
            }
            else return true;
        }
    }
}
