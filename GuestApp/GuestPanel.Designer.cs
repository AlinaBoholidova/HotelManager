namespace GuestApp
{
    partial class GuestPanel
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
            this.viewReviewsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewReviewsButton
            // 
            this.viewReviewsButton.Location = new System.Drawing.Point(230, 35);
            this.viewReviewsButton.Name = "viewReviewsButton";
            this.viewReviewsButton.Size = new System.Drawing.Size(191, 43);
            this.viewReviewsButton.TabIndex = 0;
            this.viewReviewsButton.Text = "Посмотреть отзывы";
            this.viewReviewsButton.UseVisualStyleBackColor = true;
            this.viewReviewsButton.Click += new System.EventHandler(this.buttonViewReviews_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Написать отзыв:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addReviewButton);
            this.panel1.Controls.Add(this.reviewTextBox);
            this.panel1.Controls.Add(this.viewReviewsButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 478);
            this.panel1.TabIndex = 2;
            // 
            // addReviewButton
            // 
            this.addReviewButton.Location = new System.Drawing.Point(78, 406);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(95, 33);
            this.addReviewButton.TabIndex = 3;
            this.addReviewButton.Text = "Добавить";
            this.addReviewButton.UseVisualStyleBackColor = true;
            this.addReviewButton.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Location = new System.Drawing.Point(78, 152);
            this.reviewTextBox.Multiline = true;
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(500, 231);
            this.reviewTextBox.TabIndex = 2;
            // 
            // GuestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 482);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GuestPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гостевая панель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestPanel_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewReviewsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addReviewButton;
        private System.Windows.Forms.TextBox reviewTextBox;
    }
}