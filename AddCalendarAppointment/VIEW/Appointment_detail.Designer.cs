namespace AddCalendarAppointment.VIEW
{
    partial class Appointment_detail
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.start1 = new System.Windows.Forms.DateTimePicker();
            this.start2 = new System.Windows.Forms.DateTimePicker();
            this.end1 = new System.Windows.Forms.DateTimePicker();
            this.end2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cuộc hẹn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(110, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(120, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(114, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết thúc";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(273, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(422, 30);
            this.txtname.TabIndex = 4;
            // 
            // txtlocation
            // 
            this.txtlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlocation.Location = new System.Drawing.Point(273, 158);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(422, 30);
            this.txtlocation.TabIndex = 5;
            // 
            // start1
            // 
            this.start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.start1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start1.Location = new System.Drawing.Point(273, 251);
            this.start1.Name = "start1";
            this.start1.ShowUpDown = true;
            this.start1.Size = new System.Drawing.Size(200, 30);
            this.start1.TabIndex = 6;
            // 
            // start2
            // 
            this.start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.start2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start2.Location = new System.Drawing.Point(545, 251);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(200, 30);
            this.start2.TabIndex = 8;
            // 
            // end1
            // 
            this.end1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.end1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end1.Location = new System.Drawing.Point(273, 330);
            this.end1.Name = "end1";
            this.end1.ShowUpDown = true;
            this.end1.Size = new System.Drawing.Size(200, 30);
            this.end1.TabIndex = 9;
            // 
            // end2
            // 
            this.end2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.end2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end2.Location = new System.Drawing.Point(545, 325);
            this.end2.Name = "end2";
            this.end2.Size = new System.Drawing.Size(200, 30);
            this.end2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 421);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(102, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhắc nhở";
            // 
            // Appointment_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 572);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.end2);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Appointment_detail";
            this.Text = "Appointment_detail";
            this.Load += new System.EventHandler(this.Appointment_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.DateTimePicker start1;
        private System.Windows.Forms.DateTimePicker start2;
        private System.Windows.Forms.DateTimePicker end1;
        private System.Windows.Forms.DateTimePicker end2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}