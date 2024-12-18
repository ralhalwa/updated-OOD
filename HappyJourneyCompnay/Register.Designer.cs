using System;

namespace HappyJourneyCompnay
{
    partial class Register
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username";
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(238, 114);
            this.Num.Margin = new System.Windows.Forms.Padding(2);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(211, 20);
            this.Num.TabIndex = 14;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(238, 70);
            this.lName.Margin = new System.Windows.Forms.Padding(2);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(211, 20);
            this.lName.TabIndex = 17;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(15, 250);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(209, 30);
            this.RegisterButton.TabIndex = 18;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyJourneyCompnay.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 238);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(236, 36);
            this.fName.Margin = new System.Windows.Forms.Padding(2);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(211, 20);
            this.fName.TabIndex = 19;
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(238, 149);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 20);
            this.email.TabIndex = 20;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(237, 185);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 20);
            this.password.TabIndex = 21;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(237, 221);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(211, 20);
            this.userName.TabIndex = 22;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 308);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void lName_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void DOB_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void fNmae_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
    }
}