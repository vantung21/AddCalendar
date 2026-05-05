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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace AddCalendarAppointment.VIEW
{
    public partial class GroupMeeting_detail : Form
    {
        private int appointmentId;
        appointment_detailBLL appointmentBLL = new appointment_detailBLL();
        public GroupMeeting_detail(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
        }

        private void GroupMeeting_detail_Load(object sender, EventArgs e)
        {
            appointment a = appointmentBLL.getAppointmentDetail(appointmentId);
            loadGroupMeetingDetail(a);
        }

        public void loadGroupMeetingDetail(appointment a)
        {
            if (a != null)
            {
                txtname.Text = a.title;
                txtlocation.Text = a.location;
                start1.Value = a.start_time ?? DateTime.Now;
                start2.Value = a.start_time ?? DateTime.Now;
                end1.Value = a.end_time ?? DateTime.Now;
                end2.Value = a.end_time ?? DateTime.Now;
                comboBox1.Items.Add(appointmentBLL.loadRemider(a.id));
                comboBox1.SelectedIndex = 0;
            }
            List<string> members = appointmentBLL.getGroupMeetingMembers(appointmentId);
            dataGridView1.DataSource = members.Select(m => new { Name = m }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
