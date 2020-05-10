namespace HotelManager
{
    partial class NewRoom
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
            System.Windows.Forms.Label residentsNumberLabel;
            System.Windows.Forms.Label typeLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.floorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.residentsNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            floorLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            residentsNumberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(194, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            floorLabel.Location = new System.Drawing.Point(40, 35);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(44, 17);
            floorLabel.TabIndex = 11;
            floorLabel.Text = "Floor:";
            // 
            // floorNumericUpDown
            // 
            this.floorNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Floor", true));
            this.floorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorNumericUpDown.Location = new System.Drawing.Point(178, 35);
            this.floorNumericUpDown.Maximum = new decimal(new int[] {
            10,
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
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(40, 61);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(62, 17);
            numberLabel.TabIndex = 13;
            numberLabel.Text = "Number:";
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Number", true));
            this.numberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberNumericUpDown.Location = new System.Drawing.Point(178, 61);
            this.numberNumericUpDown.Maximum = new decimal(new int[] {
            20,
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
            this.numberNumericUpDown.TabIndex = 14;
            this.numberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(40, 87);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "Price:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Price", true));
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(178, 87);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.priceNumericUpDown.TabIndex = 16;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // residentsNumberLabel
            // 
            residentsNumberLabel.AutoSize = true;
            residentsNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            residentsNumberLabel.Location = new System.Drawing.Point(40, 113);
            residentsNumberLabel.Name = "residentsNumberLabel";
            residentsNumberLabel.Size = new System.Drawing.Size(129, 17);
            residentsNumberLabel.TabIndex = 17;
            residentsNumberLabel.Text = "Residents Number:";
            // 
            // residentsNumberNumericUpDown
            // 
            this.residentsNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "ResidentsNumber", true));
            this.residentsNumberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residentsNumberNumericUpDown.Location = new System.Drawing.Point(178, 113);
            this.residentsNumberNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.residentsNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.residentsNumberNumericUpDown.Name = "residentsNumberNumericUpDown";
            this.residentsNumberNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.residentsNumberNumericUpDown.TabIndex = 18;
            this.residentsNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            typeLabel.Location = new System.Drawing.Point(40, 142);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 17);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Type", true));
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "DBL",
            "DBL TWN",
            "DBL+EXB"});
            this.typeComboBox.Location = new System.Drawing.Point(178, 139);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 20;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HotelManager.Models.Room);
            // 
            // NewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 252);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorNumericUpDown);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberNumericUpDown);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(residentsNumberLabel);
            this.Controls.Add(this.residentsNumberNumericUpDown);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.button1);
            this.Name = "NewRoom";
            this.Text = "NewRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewRoom_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.floorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown floorNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown residentsNumberNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}