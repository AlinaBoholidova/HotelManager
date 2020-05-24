namespace AdminApp
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loadButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moveOutTodayButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.checkOutTodayButton = new System.Windows.Forms.Button();
            this.moveOutButton = new System.Windows.Forms.Button();
            this.editResidentButton = new System.Windows.Forms.Button();
            this.addResidentButton = new System.Windows.Forms.Button();
            this.regRecsGridView = new System.Windows.Forms.DataGridView();
            this.ResSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.editRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.occupiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.renewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.paramComboBox = new System.Windows.Forms.ComboBox();
            this.residentsDataGridView = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reviewsTextBox = new System.Windows.Forms.TextBox();
            this.regRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regRecsGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 519);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.loadButton);
            this.tabPage1.Controls.Add(this.welcomeLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(335, 441);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(209, 37);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Загрузить данные отеля";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(343, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminApp.Properties.Resources.hotelname;
            this.pictureBox1.InitialImage = global::AdminApp.Properties.Resources.hotelname;
            this.pictureBox1.Location = new System.Drawing.Point(175, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moveOutTodayButton);
            this.tabPage2.Controls.Add(this.showAllButton);
            this.tabPage2.Controls.Add(this.checkOutTodayButton);
            this.tabPage2.Controls.Add(this.moveOutButton);
            this.tabPage2.Controls.Add(this.editResidentButton);
            this.tabPage2.Controls.Add(this.addResidentButton);
            this.tabPage2.Controls.Add(this.regRecsGridView);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список постояльцев";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moveOutTodayButton
            // 
            this.moveOutTodayButton.Location = new System.Drawing.Point(680, 246);
            this.moveOutTodayButton.Name = "moveOutTodayButton";
            this.moveOutTodayButton.Size = new System.Drawing.Size(119, 43);
            this.moveOutTodayButton.TabIndex = 6;
            this.moveOutTodayButton.Text = "Выселить [сейчас]";
            this.moveOutTodayButton.UseVisualStyleBackColor = true;
            this.moveOutTodayButton.Click += new System.EventHandler(this.moveOutTodayButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(619, 440);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 28);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Все";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // checkOutTodayButton
            // 
            this.checkOutTodayButton.Location = new System.Drawing.Point(700, 440);
            this.checkOutTodayButton.Name = "checkOutTodayButton";
            this.checkOutTodayButton.Size = new System.Drawing.Size(151, 28);
            this.checkOutTodayButton.TabIndex = 4;
            this.checkOutTodayButton.Text = "Уезжают сегодня";
            this.checkOutTodayButton.UseVisualStyleBackColor = true;
            this.checkOutTodayButton.Click += new System.EventHandler(this.checkOutTodayButton_Click);
            // 
            // moveOutButton
            // 
            this.moveOutButton.Location = new System.Drawing.Point(680, 307);
            this.moveOutButton.Name = "moveOutButton";
            this.moveOutButton.Size = new System.Drawing.Size(119, 43);
            this.moveOutButton.TabIndex = 3;
            this.moveOutButton.Text = "Выселить [раньше|позже]";
            this.moveOutButton.UseVisualStyleBackColor = true;
            this.moveOutButton.Click += new System.EventHandler(this.moveOutButton_Click);
            // 
            // editResidentButton
            // 
            this.editResidentButton.Location = new System.Drawing.Point(680, 187);
            this.editResidentButton.Name = "editResidentButton";
            this.editResidentButton.Size = new System.Drawing.Size(119, 43);
            this.editResidentButton.TabIndex = 2;
            this.editResidentButton.Text = "Редактировать данные";
            this.editResidentButton.UseVisualStyleBackColor = true;
            this.editResidentButton.Click += new System.EventHandler(this.editResidentButton_Click);
            // 
            // addResidentButton
            // 
            this.addResidentButton.Location = new System.Drawing.Point(680, 129);
            this.addResidentButton.Name = "addResidentButton";
            this.addResidentButton.Size = new System.Drawing.Size(119, 43);
            this.addResidentButton.TabIndex = 1;
            this.addResidentButton.Text = "Заселить постояльца";
            this.addResidentButton.UseVisualStyleBackColor = true;
            this.addResidentButton.Click += new System.EventHandler(this.addResidentButton_Click);
            // 
            // regRecsGridView
            // 
            this.regRecsGridView.AllowUserToAddRows = false;
            this.regRecsGridView.AllowUserToDeleteRows = false;
            this.regRecsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.regRecsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.regRecsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.regRecsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.regRecsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regRecsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResSurname,
            this.ResName,
            this.Gender,
            this.BirthDate,
            this.Phone,
            this.Email,
            this.Floor,
            this.Number,
            this.ArrivalDate,
            this.DepartureDate,
            this.Total});
            this.regRecsGridView.Location = new System.Drawing.Point(17, 17);
            this.regRecsGridView.MultiSelect = false;
            this.regRecsGridView.Name = "regRecsGridView";
            this.regRecsGridView.ReadOnly = true;
            this.regRecsGridView.RowHeadersVisible = false;
            this.regRecsGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.regRecsGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regRecsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.regRecsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.regRecsGridView.RowTemplate.Height = 35;
            this.regRecsGridView.RowTemplate.ReadOnly = true;
            this.regRecsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.regRecsGridView.Size = new System.Drawing.Size(596, 451);
            this.regRecsGridView.TabIndex = 0;
            // 
            // ResSurname
            // 
            this.ResSurname.HeaderText = "Фамилия";
            this.ResSurname.Name = "ResSurname";
            this.ResSurname.ReadOnly = true;
            this.ResSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResName
            // 
            this.ResName.HeaderText = "Имя";
            this.ResName.Name = "ResName";
            this.ResName.ReadOnly = true;
            this.ResName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.HeaderText = "Эл.почта";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.HeaderText = "Дата приезда";
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.ReadOnly = true;
            this.ArrivalDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Дата отъезда";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.HeaderText = "Сумма к оплате";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteRoomButton);
            this.tabPage3.Controls.Add(this.editRoomButton);
            this.tabPage3.Controls.Add(this.addRoomButton);
            this.tabPage3.Controls.Add(this.roomGridView);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список номеров";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(676, 285);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(118, 46);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "Удалить номер";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // editRoomButton
            // 
            this.editRoomButton.Location = new System.Drawing.Point(676, 215);
            this.editRoomButton.Name = "editRoomButton";
            this.editRoomButton.Size = new System.Drawing.Size(118, 46);
            this.editRoomButton.TabIndex = 2;
            this.editRoomButton.Text = "Редактировать номер";
            this.editRoomButton.UseVisualStyleBackColor = true;
            this.editRoomButton.Click += new System.EventHandler(this.editRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(676, 140);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(118, 46);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "Добавить номер";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomGridView
            // 
            this.roomGridView.AllowUserToAddRows = false;
            this.roomGridView.AllowUserToDeleteRows = false;
            this.roomGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.roomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.roomGridView.AutoGenerateColumns = false;
            this.roomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.roomGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.occupiedDataGridViewCheckBoxColumn});
            this.roomGridView.DataSource = this.roomBindingSource;
            this.roomGridView.Location = new System.Drawing.Point(19, 18);
            this.roomGridView.MultiSelect = false;
            this.roomGridView.Name = "roomGridView";
            this.roomGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomGridView.RowHeadersVisible = false;
            this.roomGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.roomGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roomGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.roomGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.roomGridView.RowTemplate.Height = 60;
            this.roomGridView.RowTemplate.ReadOnly = true;
            this.roomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomGridView.Size = new System.Drawing.Size(609, 441);
            this.roomGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Floor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Этаж";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ResidentsNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол-во мест";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Фото";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // occupiedDataGridViewCheckBoxColumn
            // 
            this.occupiedDataGridViewCheckBoxColumn.DataPropertyName = "Occupied";
            this.occupiedDataGridViewCheckBoxColumn.HeaderText = "Занятость";
            this.occupiedDataGridViewCheckBoxColumn.Name = "occupiedDataGridViewCheckBoxColumn";
            this.occupiedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelManagerLibrary.Models.Room);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.renewButton);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.searchTextBox);
            this.tabPage4.Controls.Add(this.paramComboBox);
            this.tabPage4.Controls.Add(this.residentsDataGridView);
            this.tabPage4.Controls.Add(this.searchButton);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(858, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Поиск";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // renewButton
            // 
            this.renewButton.Location = new System.Drawing.Point(713, 38);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(82, 24);
            this.renewButton.TabIndex = 5;
            this.renewButton.Text = "Обновить";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(301, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(368, 23);
            this.searchTextBox.TabIndex = 2;
            // 
            // paramComboBox
            // 
            this.paramComboBox.FormattingEnabled = true;
            this.paramComboBox.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Дата рождения"});
            this.paramComboBox.Location = new System.Drawing.Point(141, 38);
            this.paramComboBox.Name = "paramComboBox";
            this.paramComboBox.Size = new System.Drawing.Size(136, 24);
            this.paramComboBox.TabIndex = 1;
            // 
            // residentsDataGridView
            // 
            this.residentsDataGridView.AllowUserToAddRows = false;
            this.residentsDataGridView.AllowUserToDeleteRows = false;
            this.residentsDataGridView.AllowUserToOrderColumns = true;
            this.residentsDataGridView.AutoGenerateColumns = false;
            this.residentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.residentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.residentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.residentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.residentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.residentsDataGridView.DataSource = this.residentBindingSource;
            this.residentsDataGridView.Location = new System.Drawing.Point(64, 107);
            this.residentsDataGridView.MultiSelect = false;
            this.residentsDataGridView.Name = "residentsDataGridView";
            this.residentsDataGridView.ReadOnly = true;
            this.residentsDataGridView.RowHeadersVisible = false;
            this.residentsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.residentsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            this.residentsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.residentsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.residentsDataGridView.RowTemplate.Height = 30;
            this.residentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.residentsDataGridView.Size = new System.Drawing.Size(731, 352);
            this.residentsDataGridView.TabIndex = 0;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Эл.почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataSource = typeof(HotelManagerLibrary.Models.Resident);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::AdminApp.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(675, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(24, 24);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reviewsTextBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(858, 486);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Отзывы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reviewsTextBox
            // 
            this.reviewsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reviewsTextBox.Location = new System.Drawing.Point(115, 84);
            this.reviewsTextBox.Multiline = true;
            this.reviewsTextBox.Name = "reviewsTextBox";
            this.reviewsTextBox.ReadOnly = true;
            this.reviewsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reviewsTextBox.Size = new System.Drawing.Size(626, 337);
            this.reviewsTextBox.TabIndex = 0;
            // 
            // regRecordBindingSource
            // 
            this.regRecordBindingSource.DataSource = typeof(HotelManagerLibrary.Models.RegRecord);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 521);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regRecsGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView roomGridView;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button editRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.TextBox reviewsTextBox;
        private System.Windows.Forms.DataGridView regRecsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn occupiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button moveOutButton;
        private System.Windows.Forms.Button editResidentButton;
        private System.Windows.Forms.Button addResidentButton;
        private System.Windows.Forms.Button checkOutTodayButton;
        private System.Windows.Forms.DataGridView residentsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox paramComboBox;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button renewButton;
        private System.Windows.Forms.BindingSource regRecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button moveOutTodayButton;
    }
}