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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.viewReviewsButton = new System.Windows.Forms.Button();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(103, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Написать отзыв:";
            // 
            // viewReviewsButton
            // 
            this.viewReviewsButton.BackColor = System.Drawing.Color.White;
            this.viewReviewsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewReviewsButton.Location = new System.Drawing.Point(235, 27);
            this.viewReviewsButton.Name = "viewReviewsButton";
            this.viewReviewsButton.Size = new System.Drawing.Size(191, 43);
            this.viewReviewsButton.TabIndex = 0;
            this.viewReviewsButton.Text = "Посмотреть отзывы";
            this.viewReviewsButton.UseVisualStyleBackColor = false;
            this.viewReviewsButton.Click += new System.EventHandler(this.buttonViewReviews_Click);
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewTextBox.Location = new System.Drawing.Point(71, 146);
            this.reviewTextBox.Multiline = true;
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(500, 231);
            this.reviewTextBox.TabIndex = 2;
            // 
            // addReviewButton
            // 
            this.addReviewButton.BackColor = System.Drawing.Color.White;
            this.addReviewButton.Location = new System.Drawing.Point(107, 404);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(95, 33);
            this.addReviewButton.TabIndex = 3;
            this.addReviewButton.Text = "Добавить";
            this.addReviewButton.UseVisualStyleBackColor = false;
            this.addReviewButton.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // GuestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(660, 482);
            this.Controls.Add(this.reviewTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addReviewButton);
            this.Controls.Add(this.viewReviewsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GuestPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гостевая панель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewReviewsButton;
        private System.Windows.Forms.TextBox reviewTextBox;
        private System.Windows.Forms.Button addReviewButton;
    }
}