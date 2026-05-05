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
    public partial class Add_Appointment : Form
    {
        public Add_Appointment()
        {
            InitializeComponent();
            loadReminder();
        }

        public void loadReminder()
        {
            comboBox1.Items.AddRange(new string[] 
            {
                "5 phút trước", 
                "10 phút trước", 
                "15 phút trước",
                "30 phút trước",
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calendar calendarBLL = new calendar();

            //kiểm tra nếu có dữ liệu nào bị bỏ trống hay không
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtlocation.Text) ||
                comboBox1.SelectedIndex == -1 ||
                (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = txtName.Text;
            string location = txtlocation.Text;
            string reminder = comboBox1.SelectedItem.ToString();
            string type = radioButton1.Checked ? "Appointment" : "GroupMeeting";


            // kiểm tra nếu thời gian bắt đầu lớn hơn thời gian kết thúc hay không
            if (startTime1.Value >= endTime2.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startTime = startTime2.Value.Date + startTime1.Value.TimeOfDay;
            DateTime endTime = endTime2.Value.Date + endTime1.Value.TimeOfDay;
            if (startTime >= endTime)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var conflictResult = calendarBLL.checkConflict(title, location, startTime, endTime);
            if (conflictResult.type == 1)
            {
                DialogResult result = MessageBox.Show("Có cuộc hẹn bị trùng bạn có muốn thay thế cuộc hẹn đó không", "Trùng lịch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // Thay thế cuộc hẹn trùng lặp bằng cuộc hẹn mới
                    bool removeResult = calendarBLL.removeAppointment(conflictResult.appointmentId);
                    if (removeResult)
                    {
                        bool addResult = calendarBLL.addAppointment(title, location, reminder, type, startTime, endTime);
                        if (addResult)
                        {
                            MessageBox.Show("Cuộc hẹn đã được thay thế thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm cuộc hẹn mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (conflictResult.type == 2)
            {
                DialogResult result = MessageBox.Show("Lịch này trùng với cuộc họp nhóm khác, bạn có muốn tham gia không", "Trùng lịch", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    // Tham gia cuộc họp nhóm trùng lặp
                    bool joinResult = calendarBLL.joinGroupMeeting(conflictResult.appointmentId);
                    if (joinResult)
                    {
                        MessageBox.Show("Bạn đã tham gia cuộc họp nhóm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi tham gia cuộc họp nhóm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                bool addResult = calendarBLL.addAppointment(title, location, reminder, type, startTime, endTime);
                if (addResult)
                {
                    MessageBox.Show("Cuộc hẹn đã được thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm cuộc hẹn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
