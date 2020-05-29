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
    // Форма для відображення тексту квитанції та підтвердження її роздрукування (збереження).
    //
    public partial class ReceiptForm : Form
    {
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"AdminApp\bin\Debug\");
        RegRecord regRecord;

        // Змінна для зберігання запису реєстрації, який передався формі, на випадок
        // відміни користувачем роздрукування квитанції.
        RegRecord originalRegRecord;

        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(RegRecord regRecord) : this()
        {
            originalRegRecord = regRecord;

            this.regRecord = regRecord;
            receiptTextBox.Text += "ОТЕЛЬ ATLAS HOTELS" + Environment.NewLine;
            receiptTextBox.Text += "Квитанция на оплату" + Environment.NewLine + Environment.NewLine;
            receiptTextBox.Text += $"Плательщик: {regRecord.Resident.Surname} {regRecord.Resident.Name}" + 
                Environment.NewLine;
            receiptTextBox.Text += $"Заезд: {regRecord.ArrivalDate.ToShortDateString()}   " +
                $"Выезд: {regRecord.DepartureDate.ToShortDateString()}" + Environment.NewLine;
            receiptTextBox.Text += "Проживание" + Environment.NewLine + Environment.NewLine;
            receiptTextBox.Text += $"Тип: {regRecord.Room.Type}   Этаж: {regRecord.Room.Floor}   " +
                $"Номер: {regRecord.Room.Number}" + Environment.NewLine;
            receiptTextBox.Text += $"Цена номера: {regRecord.Room.Price} грн." + Environment.NewLine + 
                Environment.NewLine;
            receiptTextBox.Text += $"Сумма к оплате: {regRecord.Total} грн.";
        }

        private void saveReceiptButton_Click(object sender, EventArgs e)
        {
            SaveReceipt(receiptTextBox);
        }

        private void SaveReceipt(TextBox receipt)
        {
            File.WriteAllText(path + regRecord.GetReceiptName(regRecord), receipt.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            regRecord = originalRegRecord;
        }
    }
}
