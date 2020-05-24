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
            this.receiptTextBox = new System.Windows.Forms.TextBox();
            this.saveReceiptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptTextBox
            // 
            this.receiptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptTextBox.Location = new System.Drawing.Point(71, 58);
            this.receiptTextBox.Multiline = true;
            this.receiptTextBox.Name = "receiptTextBox";
            this.receiptTextBox.ReadOnly = true;
            this.receiptTextBox.Size = new System.Drawing.Size(379, 282);
            this.receiptTextBox.TabIndex = 0;
            this.receiptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveReceiptButton
            // 
            this.saveReceiptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveReceiptButton.Location = new System.Drawing.Point(284, 389);
            this.saveReceiptButton.Name = "saveReceiptButton";
            this.saveReceiptButton.Size = new System.Drawing.Size(101, 31);
            this.saveReceiptButton.TabIndex = 1;
            this.saveReceiptButton.Text = "Распечатать";
            this.saveReceiptButton.UseVisualStyleBackColor = true;
            this.saveReceiptButton.Click += new System.EventHandler(this.saveReceiptButton_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(402, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveReceiptButton);
            this.Controls.Add(this.receiptTextBox);
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квитанция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiptTextBox;
        private System.Windows.Forms.Button saveReceiptButton;
        private System.Windows.Forms.Button button2;
    }
}