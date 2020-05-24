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
    public partial class ReceiptForm : Form
    {
        RegRecord regRecord = MoveOutForm.RegRecord;
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"AdminApp\bin\Debug\");
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(RegRecord regRecord) : this()
        {
            receiptTextBox.Text += "ОТЕЛЬ ATLAS HOTELS" + Environment.NewLine;
            receiptTextBox.Text += "Квитанция на оплату" + Environment.NewLine + Environment.NewLine;
            receiptTextBox.Text += $"Плательщик: {regRecord.Resident.Surname} {regRecord.Resident.Name}" + Environment.NewLine;
            receiptTextBox.Text += $"Заезд: {regRecord.ArrivalDate.ToShortDateString()}   Выезд: {regRecord.DepartureDate.ToShortDateString()}" + Environment.NewLine;
            receiptTextBox.Text += "Проживание" + Environment.NewLine + Environment.NewLine;
            receiptTextBox.Text += $"Тип: {regRecord.Room.Type}   Этаж: {regRecord.Room.Floor}   Номер: {regRecord.Room.Number}" + Environment.NewLine;
            receiptTextBox.Text += $"Цена номера: {regRecord.Room.Price} грн." + Environment.NewLine + Environment.NewLine;
            receiptTextBox.Text += $"Сумма к оплате: {regRecord.Total} грн.";
        }

        private void saveReceiptButton_Click(object sender, EventArgs e)
        {
            SaveReceipt(receiptTextBox);
        }

        public void SaveReceipt(TextBox receipt)
        {
            File.WriteAllText(path + GetReceiptName(regRecord), receipt.Text);
        }

        public string GetReceiptName(RegRecord regRecord)
        {
            return $"receipt_{regRecord.Resident.Surname}.txt";
        }
    }
}
