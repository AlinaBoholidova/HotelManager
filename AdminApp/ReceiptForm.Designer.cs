namespace AdminApp
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.receiptTextBox = new System.Windows.Forms.TextBox();
            this.saveReceiptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptTextBox
            // 
            this.receiptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptTextBox.Location = new System.Drawing.Point(76, 92);
            this.receiptTextBox.Multiline = true;
            this.receiptTextBox.Name = "receiptTextBox";
            this.receiptTextBox.ReadOnly = true;
            this.receiptTextBox.Size = new System.Drawing.Size(379, 282);
            this.receiptTextBox.TabIndex = 0;
            this.receiptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveReceiptButton
            // 
            this.saveReceiptButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveReceiptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveReceiptButton.Location = new System.Drawing.Point(312, 391);
            this.saveReceiptButton.Name = "saveReceiptButton";
            this.saveReceiptButton.Size = new System.Drawing.Size(102, 34);
            this.saveReceiptButton.TabIndex = 1;
            this.saveReceiptButton.Text = "Распечатать";
            this.saveReceiptButton.UseVisualStyleBackColor = false;
            this.saveReceiptButton.Click += new System.EventHandler(this.saveReceiptButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(430, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::AdminApp.Properties.Resources.receipt;
            this.pictureBox1.Location = new System.Drawing.Point(234, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(530, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveReceiptButton);
            this.Controls.Add(this.receiptTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Квитанция";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiptTextBox;
        private System.Windows.Forms.Button saveReceiptButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}