using AddCalendarAppointment.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddCalendarAppointment.VIEW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            calendar calendarBLL = new calendar();

            dataGridView1.DataSource = calendarBLL.loadAppointment(radioButton.Text);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Appointment add_appointmentForm = new Add_Appointment();
            add_appointmentForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa cuộc hẹn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                return;
            }
            calendar calendarBLL = new calendar();
            if(dataGridView1.SelectedRows.Count == 1)
            {
                bool result = calendarBLL.removeAppointment((int)dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if(result)
                {   
                    dataGridView1.DataSource = calendarBLL.loadAppointment(radioGroup.Checked ? radioGroup.Text : radioAppoint.Text);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                MessageBox.Show(result ? "Xoá cuộc hẹn thành công." : "Lỗi không thể xoá cuộc hẹn này!.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            calendar calendarBLL = new calendar();
            
            if(dataGridView1.SelectedRows.Count == 1)
            {
                int appointmentId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                if (radioAppoint.Checked)
                {
                    Appointment_detail a = new Appointment_detail(appointmentId);
                    a.ShowDialog();
                }
                else
                {
                    GroupMeeting_detail m = new GroupMeeting_detail(appointmentId);
                    m.ShowDialog();
                }

            }
            
        }
    }
}
