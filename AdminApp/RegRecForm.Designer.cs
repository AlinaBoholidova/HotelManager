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
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label actualResidentsLabel;
            System.Windows.Forms.Label totalLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegRecForm));
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.backButton = new System.Windows.Forms.Button();
            this.actualResidentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            arrivalDateLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            actualResidentsLabel = new System.Windows.Forms.Label();
            totalLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualResidentsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.ForeColor = System.Drawing.Color.White;
            arrivalDateLabel.Location = new System.Drawing.Point(426, 173);
            arrivalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new System.Drawing.Size(105, 17);
            arrivalDateLabel.TabIndex = 0;
            arrivalDateLabel.Text = "Дата приезда:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.ForeColor = System.Drawing.Color.White;
            departureDateLabel.Location = new System.Drawing.Point(426, 211);
            departureDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(105, 17);
            departureDateLabel.TabIndex = 2;
            departureDateLabel.Text = "Дата отъезда:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.ForeColor = System.Drawing.Color.White;
            birthDateLabel.Location = new System.Drawing.Point(8, 130);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(115, 17);
            birthDateLabel.TabIndex = 6;
            birthDateLabel.Text = "Дата рождения:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(8, 211);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(8, 93);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(38, 17);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Пол:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(8, 54);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 17);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = System.Drawing.Color.White;
            phoneLabel.Location = new System.Drawing.Point(8, 173);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(72, 17);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Телефон:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.ForeColor = System.Drawing.Color.White;
            surnameLabel.Location = new System.Drawing.Point(8, 13);
            surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 17);
            surnameLabel.TabIndex = 16;
            surnameLabel.Text = "Фамилия:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.ForeColor = System.Drawing.Color.White;
            floorLabel.Location = new System.Drawing.Point(426, 54);
            floorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(45, 17);
            floorLabel.TabIndex = 18;
            floorLabel.Text = "Этаж:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.ForeColor = System.Drawing.Color.White;
            numberLabel.Location = new System.Drawing.Point(426, 93);
            numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 17);
            numberLabel.TabIndex = 20;
            numberLabel.Text = "Номер:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.ForeColor = System.Drawing.Color.White;
            typeLabel.Location = new System.Drawing.Point(426, 13);
            typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(37, 17);
            typeLabel.TabIndex = 22;
            typeLabel.Text = "Тип:";
            // 
            // actualResidentsLabel
            // 
            actualResidentsLabel.AutoSize = true;
            actualResidentsLabel.ForeColor = System.Drawing.Color.White;
            actualResidentsLabel.Location = new System.Drawing.Point(425, 130);
            actualResidentsLabel.Name = "actualResidentsLabel";
            actualResidentsLabel.Size = new System.Drawing.Size(111, 17);
            actualResidentsLabel.TabIndex = 26;
            actualResidentsLabel.Text = "Коль-во гостей:";
            // 
            // totalLabel1
            // 
            totalLabel1.AutoSize = true;
            totalLabel1.ForeColor = System.Drawing.Color.White;
            totalLabel1.Location = new System.Drawing.Point(425, 249);
            totalLabel1.Name = "totalLabel1";
            totalLabel1.Size = new System.Drawing.Size(116, 17);
            totalLabel1.TabIndex = 27;
            totalLabel1.Text = "Сумма к оплате:";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "ArrivalDate", true));
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(545, 168);
            this.arrivalDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.arrivalDateTimePicker.TabIndex = 11;
            // 
            // regRecordBindingSource
            // 
            this.regRecordBindingSource.DataSource = typeof(HotelManagerLibrary.Models.RegRecord);
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "DepartureDate", true));
            this.departureDateTimePicker.Location = new System.Drawing.Point(545, 206);
            this.departureDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.departureDateTimePicker.TabIndex = 12;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "Resident.BirthDate", true));
            this.birthDateTimePicker.Location = new System.Drawing.Point(131, 130);
            this.birthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.birthDateTimePicker.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(131, 208);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(230, 23);
            this.emailTextBox.TabIndex = 6;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж",
            "-"});
            this.genderComboBox.Location = new System.Drawing.Point(131, 90);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(50, 24);
            this.genderComboBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(131, 51);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(131, 170);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(230, 23);
            this.phoneTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(131, 10);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(230, 23);
            this.surnameTextBox.TabIndex = 1;
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Location = new System.Drawing.Point(545, 51);
            this.floorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(50, 24);
            this.floorComboBox.TabIndex = 8;
            this.floorComboBox.SelectedIndexChanged += new System.EventHandler(this.floorComboBox_SelectedIndexChanged);
            // 
            // numberComboBox
            // 
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(545, 90);
            this.numberComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(50, 24);
            this.numberComboBox.TabIndex = 9;
            this.numberComboBox.SelectedIndexChanged += new System.EventHandler(this.numberComboBox_SelectedIndexChanged);
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
            this.typeComboBox.Location = new System.Drawing.Point(545, 10);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(160, 24);
            this.typeComboBox.TabIndex = 7;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(11, 313);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(99, 36);
            this.receiptButton.TabIndex = 14;
            this.receiptButton.Text = "Квитанция";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(713, 313);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 36);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Вернуться";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // actualResidentsNumericUpDown
            // 
            this.actualResidentsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "Room.ActualResidents", true));
            this.actualResidentsNumericUpDown.Location = new System.Drawing.Point(545, 128);
            this.actualResidentsNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.actualResidentsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.actualResidentsNumericUpDown.Name = "actualResidentsNumericUpDown";
            this.actualResidentsNumericUpDown.Size = new System.Drawing.Size(50, 23);
            this.actualResidentsNumericUpDown.TabIndex = 10;
            this.actualResidentsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Total", true));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalLabel.Location = new System.Drawing.Point(544, 246);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(599, 313);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 36);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // RegRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(824, 361);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(totalLabel1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(actualResidentsLabel);
            this.Controls.Add(this.actualResidentsNumericUpDown);
            this.Controls.Add(this.backButton);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(840, 400);
            this.Name = "RegRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запись регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualResidentsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource regRecordBindingSource;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.NumericUpDown actualResidentsNumericUpDown;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button saveButton;
    }
}