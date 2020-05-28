namespace AdminApp
{
    partial class RoomForm
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
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.confirmButton = new System.Windows.Forms.Button();
            this.floorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            floorLabel.ForeColor = System.Drawing.Color.White;
            floorLabel.Location = new System.Drawing.Point(16, 111);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(45, 17);
            floorLabel.TabIndex = 11;
            floorLabel.Text = "Этаж:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.ForeColor = System.Drawing.Color.White;
            numberLabel.Location = new System.Drawing.Point(16, 148);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 17);
            numberLabel.TabIndex = 15;
            numberLabel.Text = "Номер:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(16, 186);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 17);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Цена:";
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(35, 235);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // floorNumericUpDown
            // 
            this.floorNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Floor", true));
            this.floorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorNumericUpDown.Location = new System.Drawing.Point(84, 111);
            this.floorNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.floorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorNumericUpDown.Name = "floorNumericUpDown";
            this.floorNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.floorNumericUpDown.TabIndex = 12;
            this.floorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.imagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.roomBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(233, 30);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(353, 243);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 14;
            this.imagePictureBox.TabStop = false;
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Number", true));
            this.numberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberNumericUpDown.Location = new System.Drawing.Point(84, 148);
            this.numberNumericUpDown.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberNumericUpDown.Name = "numberNumericUpDown";
            this.numberNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.numberNumericUpDown.TabIndex = 16;
            this.numberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Price", true));
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(84, 186);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.priceNumericUpDown.TabIndex = 18;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(116, 235);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "Изображение";
            this.imageFileDialog.Filter = "Файлы изображений|*.jpg";
            this.imageFileDialog.RestoreDirectory = true;
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseImageButton.Location = new System.Drawing.Point(26, 50);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(174, 28);
            this.chooseImageButton.TabIndex = 22;
            this.chooseImageButton.Text = "Выбрать изображение";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelManagerLibrary.Models.Room);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(613, 307);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorNumericUpDown);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberNumericUpDown);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.confirmButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные номера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.NumericUpDown floorNumericUpDown;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.NumericUpDown numberNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.Button chooseImageButton;
    }
}