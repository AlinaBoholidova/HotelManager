namespace AdminApp
{
    partial class RegRecForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label arrivalDateLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label typeLabel;
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            arrivalDateLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Location = new System.Drawing.Point(461, 169);
            arrivalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new System.Drawing.Size(105, 17);
            arrivalDateLabel.TabIndex = 0;
            arrivalDateLabel.Text = "Дата приезда:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(461, 201);
            departureDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(105, 17);
            departureDateLabel.TabIndex = 2;
            departureDateLabel.Text = "Дата отъезда:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(450, 231);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(116, 17);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Сумма к оплате:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(4, 138);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(115, 17);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Дата рождения:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(68, 225);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(76, 108);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(38, 17);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Пол:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(76, 71);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 17);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(47, 180);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(72, 17);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Телефон:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(41, 34);
            surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 17);
            surnameLabel.TabIndex = 16;
            surnameLabel.Text = "Фамилия:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(471, 77);
            floorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(45, 17);
            floorLabel.TabIndex = 18;
            floorLabel.Text = "Этаж:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(461, 111);
            numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 17);
            numberLabel.TabIndex = 20;
            numberLabel.Text = "Номер:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(479, 37);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(37, 17);
            typeLabel.TabIndex = 22;
            typeLabel.Text = "Тип:";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "ArrivalDate", true));
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(579, 164);
            this.arrivalDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.arrivalDateTimePicker.TabIndex = 1;
            // 
            // regRecordBindingSource
            // 
            this.regRecordBindingSource.DataSource = typeof(HotelManagerLibrary.Models.RegRecord);
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "DepartureDate", true));
            this.departureDateTimePicker.Location = new System.Drawing.Point(579, 196);
            this.departureDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.departureDateTimePicker.TabIndex = 3;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(579, 228);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(85, 23);
            this.totalTextBox.TabIndex = 5;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "Resident.BirthDate", true));
            this.birthDateTimePicker.Location = new System.Drawing.Point(127, 138);
            this.birthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.birthDateTimePicker.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(127, 222);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(265, 23);
            this.emailTextBox.TabIndex = 9;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж",
            "-"});
            this.genderComboBox.Location = new System.Drawing.Point(127, 103);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(265, 24);
            this.genderComboBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(127, 71);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 23);
            this.nameTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(127, 180);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(265, 23);
            this.phoneTextBox.TabIndex = 15;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(127, 34);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(265, 23);
            this.surnameTextBox.TabIndex = 17;
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Location = new System.Drawing.Point(532, 74);
            this.floorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(160, 24);
            this.floorComboBox.TabIndex = 19;
            this.floorComboBox.SelectedIndexChanged += new System.EventHandler(this.floorComboBox_SelectedIndexChanged);
            // 
            // numberComboBox
            // 
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(532, 108);
            this.numberComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(160, 24);
            this.numberComboBox.TabIndex = 21;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Городская абстракция",
            "Расслабляющий фиолетовый",
            "Свежесть утра",
            "Фанат футбола",
            "Тип номера"});
            this.typeComboBox.Location = new System.Drawing.Point(532, 34);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(160, 24);
            this.typeComboBox.TabIndex = 23;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // receiptButton
            // 
            this.receiptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.receiptButton.Location = new System.Drawing.Point(586, 288);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(99, 36);
            this.receiptButton.TabIndex = 24;
            this.receiptButton.Text = "Квитанция";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(715, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorComboBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberComboBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(arrivalDateLabel);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource regRecordBindingSource;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.ComboBox numberComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button button2;
    }
}