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
    public partial class RoomForm : Form
    {
        public Room Room { set; get; }
        public RoomForm()
        {
            InitializeComponent();
        }

        private void NewRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r = new Room
            {
                Floor = (int)floorNumericUpDown.Value,
                Number = (int)numberNumericUpDown.Value,
                Price = (int)priceNumericUpDown.Value,
                ResidentsNumber = (int)residentsNumberNumericUpDown.Value,
                Type = typeComboBox.Text
            };
            Room = r;
        }
    }
}
