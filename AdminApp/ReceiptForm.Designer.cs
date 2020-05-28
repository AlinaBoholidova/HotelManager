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
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptTextBox
            // 
            this.receiptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptTextBox.Location = new System.Drawing.Point(76, 92);
            this.receiptTextBox.Multiline = true;
            this.receiptTextBox.Name = "receiptTextBox";
            this.receiptTextBox.ReadOnly = true;
            this.receiptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.receiptTextBox.Size = new System.Drawing.Size(379, 282);
            this.receiptTextBox.TabIndex = 2;
            this.receiptTextBox.TabStop = false;
            this.receiptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveReceiptButton
            // 
            this.saveReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveReceiptButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveReceiptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveReceiptButton.Location = new System.Drawing.Point(312, 391);
            this.saveReceiptButton.Name = "saveReceiptButton";
            this.saveReceiptButton.Size = new System.Drawing.Size(102, 34);
            this.saveReceiptButton.TabIndex = 0;
            this.saveReceiptButton.Text = "Распечатать";
            this.saveReceiptButton.UseVisualStyleBackColor = false;
            this.saveReceiptButton.Click += new System.EventHandler(this.saveReceiptButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(430, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 34);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Вернуться";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveReceiptButton);
            this.Controls.Add(this.receiptTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}