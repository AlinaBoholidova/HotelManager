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
            this.confirmButton = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.floorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            floorLabel.Location = new System.Drawing.Point(12, 79);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(45, 17);
            floorLabel.TabIndex = 11;
            floorLabel.Text = "Этаж:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(12, 116);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 17);
            numberLabel.TabIndex = 15;
            numberLabel.Text = "Номер:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(12, 154);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 17);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "Цена:";
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(33, 230);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelManagerLibrary.Models.Room);
            // 
            // floorNumericUpDown
            // 
            this.floorNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Floor", true));
            this.floorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorNumericUpDown.Location = new System.Drawing.Point(80, 79);
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
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.roomBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(233, 27);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(260, 209);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 14;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Number", true));
            this.numberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberNumericUpDown.Location = new System.Drawing.Point(80, 116);
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
            this.priceNumericUpDown.Location = new System.Drawing.Point(80, 154);
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
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(114, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Выберите изображение:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorNumericUpDown);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberNumericUpDown);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.confirmButton);
            this.Name = "RoomForm";
            this.Text = "Данные номера";
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}