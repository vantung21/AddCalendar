using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCalendarAppointment.BLL
{
    public class appointment_detailBLL
    {
        private calendarDBEntities entity = new calendarDBEntities();
        private int userID = 1;

        public appointment getAppointmentDetail(int appointmentId)
        {
            var app = entity.appointments.FirstOrDefault(a => a.id == appointmentId);
            if (app != null)
            {
                if (app.user_id == userID) return app;
                if (app.is_group_meeting == true)
                {
                    bool isMember = entity.members.Any(m => m.appointment_id == appointmentId && m.user_id == userID);
                    if (isMember) return app;
                }
            }
            return null;
        }

        public List<string> getGroupMeetingMembers(int appointmentId)
        {
            var members = entity.members
                .Where(m => m.appointment_id == appointmentId)
                .Select(m => m.user_id)
                .ToList();
            var memberNames = entity.users
                .Where(u => members.Contains(u.id))
                .Select(u => u.name)
                .ToList();
            return memberNames;
        }

        public string loadRemider(int appointmentId)
        {
            var reminder = entity.reminders.FirstOrDefault(r => r.appointment_id == appointmentId);
            return reminder != null ? reminder.minutes_before.ToString() : string.Empty;
        }

    }
}
