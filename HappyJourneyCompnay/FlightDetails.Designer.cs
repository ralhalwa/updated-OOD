namespace HappyJourneyCompnay
{
    partial class FlightDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new HappyJourneyCompnay.Database1DataSet();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new HappyJourneyCompnay.Database1DataSetTableAdapters.FlightTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Display flight details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter the Flight number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search flight";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.database1DataSet;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(744, 205);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // FlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FlightDetails";
            this.Text = "FlightDetails";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private Database1DataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}