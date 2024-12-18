namespace HappyJourneyCompnay
{
    partial class EmployerMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flightDetailsButton = new System.Windows.Forms.Button();
            this.BookFlight = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // flightDetailsButton
            // 
            this.flightDetailsButton.Location = new System.Drawing.Point(8, 138);
            this.flightDetailsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightDetailsButton.Name = "flightDetailsButton";
            this.flightDetailsButton.Size = new System.Drawing.Size(145, 30);
            this.flightDetailsButton.TabIndex = 7;
            this.flightDetailsButton.Text = "Flight Details";
            this.flightDetailsButton.UseVisualStyleBackColor = true;
            this.flightDetailsButton.Click += new System.EventHandler(this.flightDetailsButton_Click);
            // 
            // BookFlight
            // 
            this.BookFlight.Location = new System.Drawing.Point(199, 138);
            this.BookFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookFlight.Name = "BookFlight";
            this.BookFlight.Size = new System.Drawing.Size(145, 30);
            this.BookFlight.TabIndex = 8;
            this.BookFlight.Text = "Book Flight";
            this.BookFlight.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(381, 138);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(145, 30);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EmployerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 308);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.BookFlight);
            this.Controls.Add(this.flightDetailsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployerMainPage";
            this.Text = "EmployerMainPage";
            this.Load += new System.EventHandler(this.EmployerMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button flightDetailsButton;
        private System.Windows.Forms.Button BookFlight;
        private System.Windows.Forms.Button searchButton;
    }
}