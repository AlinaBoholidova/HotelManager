namespace AdminApp
{
    partial class MoveOutForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label departureDateLabel;
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.regRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recalculationButton = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(42, 196);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 55);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 17);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(42, 164);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(72, 17);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Телефон:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(41, 21);
            surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 17);
            surnameLabel.TabIndex = 11;
            surnameLabel.Text = "Фамилия:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(41, 92);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(38, 17);
            genderLabel.TabIndex = 25;
            genderLabel.Text = "Пол:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(5, 128);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(115, 17);
            birthDateLabel.TabIndex = 26;
            birthDateLabel.Text = "Дата рождения:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(462, 74);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(45, 17);
            floorLabel.TabIndex = 27;
            floorLabel.Text = "Этаж:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(462, 103);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 17);
            numberLabel.TabIndex = 29;
            numberLabel.Text = "Номер:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(462, 132);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(37, 17);
            typeLabel.TabIndex = 31;
            typeLabel.Text = "Тип:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(126, 193);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(265, 23);
            this.emailTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(125, 52);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(265, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(126, 161);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(265, 23);
            this.phoneTextBox.TabIndex = 10;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(125, 18);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(265, 23);
            this.surnameTextBox.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(657, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Вернуться";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(125, 89);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(264, 23);
            this.genderTextBox.TabIndex = 26;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Resident.BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(126, 125);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(264, 23);
            this.birthDateTextBox.TabIndex = 27;
            // 
            // floorTextBox
            // 
            this.floorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Room.Floor", true));
            this.floorTextBox.Location = new System.Drawing.Point(530, 71);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(182, 23);
            this.floorTextBox.TabIndex = 28;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Room.Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(530, 100);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(182, 23);
            this.numberTextBox.TabIndex = 30;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "Room.Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(530, 129);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(182, 23);
            this.typeTextBox.TabIndex = 32;
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regRecordBindingSource, "ArrivalDate", true));
            this.arrivalDateTextBox.Location = new System.Drawing.Point(134, 283);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(236, 23);
            this.arrivalDateTextBox.TabIndex = 33;
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Location = new System.Drawing.Point(23, 285);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(105, 17);
            this.arrivalDateLabel.TabIndex = 34;
            this.arrivalDateLabel.Text = "Дата приезда:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(548, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // regRecordBindingSource
            // 
            this.regRecordBindingSource.DataSource = typeof(HotelManagerLibrary.Models.RegRecord);
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(419, 286);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(105, 17);
            departureDateLabel.TabIndex = 36;
            departureDateLabel.Text = "Дата отъезда:";
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.regRecordBindingSource, "DepartureDate", true));
            this.departureDateTimePicker.Location = new System.Drawing.Point(535, 282);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.departureDateTimePicker.TabIndex = 37;
            this.departureDateTimePicker.ValueChanged += new System.EventHandler(this.departureDateTimePicker_ValueChanged);
            // 
            // recalculationButton
            // 
            this.recalculationButton.Location = new System.Drawing.Point(26, 385);
            this.recalculationButton.Name = "recalculationButton";
            this.recalculationButton.Size = new System.Drawing.Size(88, 31);
            this.recalculationButton.TabIndex = 38;
            this.recalculationButton.Text = "Квитанция";
            this.recalculationButton.UseVisualStyleBackColor = true;
            this.recalculationButton.Visible = false;
            this.recalculationButton.Click += new System.EventHandler(this.recalculationButton_Click);
            // 
            // MoveOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 436);
            this.Controls.Add(this.recalculationButton);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrivalDateLabel);
            this.Controls.Add(this.arrivalDateTextBox);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MoveOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выселение";
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource regRecordBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.Button recalculationButton;
    }
}