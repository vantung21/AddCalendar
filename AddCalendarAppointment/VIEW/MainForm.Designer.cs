namespace AddCalendarAppointment.VIEW
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioAppoint = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioAppoint);
            this.panel1.Controls.Add(this.radioGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(297, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 74);
            this.panel1.TabIndex = 1;
            // 
            // radioAppoint
            // 
            this.radioAppoint.AutoSize = true;
            this.radioAppoint.Location = new System.Drawing.Point(479, 42);
            this.radioAppoint.Name = "radioAppoint";
            this.radioAppoint.Size = new System.Drawing.Size(103, 20);
            this.radioAppoint.TabIndex = 3;
            this.radioAppoint.TabStop = true;
            this.radioAppoint.Text = "Appointment";
            this.radioAppoint.UseVisualStyleBackColor = true;
            this.radioAppoint.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioGroup
            // 
            this.radioGroup.AutoSize = true;
            this.radioGroup.Location = new System.Drawing.Point(609, 42);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(113, 20);
            this.radioGroup.TabIndex = 2;
            this.radioGroup.TabStop = true;
            this.radioGroup.Text = "GroupMeeting";
            this.radioGroup.UseVisualStyleBackColor = true;
            this.radioGroup.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch hẹn của bạn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 435);
            this.dataGridView1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 102);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thêm cuộc hẹn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xem chi tiết cuộc hẹn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xoá cuộc hẹn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioAppoint;
        private System.Windows.Forms.RadioButton radioGroup;
    }
}