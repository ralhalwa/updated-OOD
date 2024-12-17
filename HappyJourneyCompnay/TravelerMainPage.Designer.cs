using System;

namespace HappyJourneyCompnay
{
    partial class TravelerMainPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TwoWaybtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.OneWayRadiobtn = new System.Windows.Forms.RadioButton();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(795, -50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 68);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TwoWaybtn
            // 
            this.TwoWaybtn.AutoSize = true;
            this.TwoWaybtn.Location = new System.Drawing.Point(395, 70);
            this.TwoWaybtn.Name = "TwoWaybtn";
            this.TwoWaybtn.Size = new System.Drawing.Size(98, 23);
            this.TwoWaybtn.TabIndex = 2;
            this.TwoWaybtn.TabStop = true;
            this.TwoWaybtn.Text = "Two way";
            this.TwoWaybtn.UseVisualStyleBackColor = true;
            this.TwoWaybtn.CheckedChanged += new System.EventHandler(this.TwoWaybtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(391, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 27);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // OneWayRadiobtn
            // 
            this.OneWayRadiobtn.AutoSize = true;
            this.OneWayRadiobtn.Location = new System.Drawing.Point(123, 70);
            this.OneWayRadiobtn.Name = "OneWayRadiobtn";
            this.OneWayRadiobtn.Size = new System.Drawing.Size(93, 23);
            this.OneWayRadiobtn.TabIndex = 7;
            this.OneWayRadiobtn.TabStop = true;
            this.OneWayRadiobtn.Text = "one way";
            this.OneWayRadiobtn.UseVisualStyleBackColor = true;
            this.OneWayRadiobtn.CheckedChanged += new System.EventHandler(this.OneWayRadiobtn_CheckedChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(108, 225);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(79, 19);
            this.startLabel.TabIndex = 9;
            this.startLabel.Text = "Start Date";
            this.startLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(414, 225);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(73, 19);
            this.endLabel.TabIndex = 10;
            this.endLabel.Text = "End Date";
            this.endLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // endDateTimePicker1
            // 
            this.endDateTimePicker1.Location = new System.Drawing.Point(428, 257);
            this.endDateTimePicker1.Name = "endDateTimePicker1";
            this.endDateTimePicker1.Size = new System.Drawing.Size(260, 27);
            this.endDateTimePicker1.TabIndex = 12;
            this.endDateTimePicker1.ValueChanged += new System.EventHandler(this.endDateTimePicker1_ValueChanged);
            // 
            // startDatePicker2
            // 
            this.startDatePicker2.Location = new System.Drawing.Point(81, 257);
            this.startDatePicker2.Name = "startDatePicker2";
            this.startDatePicker2.Size = new System.Drawing.Size(260, 27);
            this.startDatePicker2.TabIndex = 13;
            this.startDatePicker2.ValueChanged += new System.EventHandler(this.startDatePicker2_ValueChanged);
            // 
            // TravelerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startDatePicker2);
            this.Controls.Add(this.endDateTimePicker1);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.OneWayRadiobtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TwoWaybtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "TravelerMainPage";
            this.Text = "TravelerMainPage";
            this.Load += new System.EventHandler(this.TravelerMainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton TwoWaybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton OneWayRadiobtn;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker1;
        private System.Windows.Forms.DateTimePicker startDatePicker2;
    }
}