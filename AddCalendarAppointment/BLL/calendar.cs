using AddCalendarAppointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AddCalendarAppointment.BLL
{
    public class calendar
    {
        private calendarDBEntities entity = new calendarDBEntities();
        private int userID = 1;
        public List<appointmentView> loadAppointment(string type)
        {
            if (type == "Appointment")
            {
                var appointments = entity.appointments
                .Where(a => a.user_id == userID && a.is_group_meeting == false)  // Lọc theo user_id
                .Select(p => new { p.id, p.title, p.start_time, })
                .AsEnumerable()  // Chuyển từ LINQ to Entities sang LINQ to Objects
                .Select(p => new appointmentView()
                {
                    Id = p.id,
                    Title = p.title,
                    // Xử lý null nếu start_time là DateTime?
                    Time = p.start_time?.ToString("dd/MM/yyyy HH:mm") ?? string.Empty,
                })
                .ToList();

                return appointments;
            }
            else
            {
                // Lọc chỉ những cuộc họp nhóm và gộp vào một danh sách riêng để biết userID nào có bao nhiêu cuộc họp nhóm
                var groupMeetings = entity.appointments
                .Where(a => a.is_group_meeting == true)
                .Join(entity.members,
                a => a.id,
                m => m.appointment_id,
                (a, m) => new { a.id, a.title, a.start_time, m.user_id })
                .Where(p => p.user_id == userID)  // Lọc theo user_id
                .AsEnumerable()
                .Select(p => new appointmentView()
                {
                    Id = p.id,
                    Title = p.title,
                    Time = p.start_time?.ToString("dd/MM/yyyy HH:mm") ?? string.Empty,
                }).ToList();

                return groupMeetings;

            }
        }

        public (int type, int[] appointmentId) checkConflict(string title, string location, DateTime startTime, DateTime endTime)
        {
            //kiểm tra xem có cuộc hẹn nào của userID bị trùng với khoảng thời gian đã chọn hay không
            var conflict = entity.appointments
                .Where(a => a.user_id == userID && a.start_time < endTime && a.end_time > startTime);
            if (conflict != null && conflict.Any()) 
            {
                return (1, conflict.Select(a => a.id).ToArray()); //có cuộc hẹn bị trùng
            }

            //kiểm tra có cuộc họp nhóm nào mà userID tham gia bị trùng với khoảng thời gian đã chọn hay không
            var groupConflict = entity.appointments
                .Where(a => a.is_group_meeting == true)
                .Join(entity.members,
                a => a.id,
                m => m.appointment_id,
                (a, m) => new { a.id, a.start_time, a.end_time, m.user_id })
                .Where(p => p.user_id == userID && p.start_time < endTime && p.end_time > startTime)
                .FirstOrDefault();
            if (groupConflict != null)
            {
                return (1, new int[] { groupConflict.id }); //có cuộc họp nhóm bị trùng
            }

            //kiểm  tra xem có cuộc hẹn nhóm nào có cùng tên, thời gian bắt đầu và kết thúc trùng với cuộc hẹn mới hay không và user chưa tham gia cuộc họp nhóm đó
            var duplicateGroupMeeting = entity.appointments
                .Where(a => a.is_group_meeting == true && a.title == title && a.start_time == startTime && a.end_time == endTime)
                .FirstOrDefault();
            if (duplicateGroupMeeting != null)
            {
                return (2, new int[] { duplicateGroupMeeting.id }); //có cuộc họp nhóm trùng lặp
            }

            return (0, new int[] { -1 }); //không có cuộc hẹn hoặc cuộc họp nhóm nào bị trùng
        }

        public bool addAppointment(string title, string location, string reminderStr, string type, DateTime startTime, DateTime endTime)
        {
            try
            {
                appointment newAppointment = new appointment()
                {
                    user_id = userID,
                    title = title,
                    location = location,
                    is_group_meeting = (type == "GroupMeeting"),
                    start_time = startTime,
                    end_time = endTime
                };
                entity.appointments.Add(newAppointment);
                entity.SaveChanges();

                addReminder(newAppointment.id, reminderStr);

                if (type == "GroupMeeting")
                {
                    joinGroupMeeting(newAppointment.id);
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                return false;
            }
        }

        public bool addReminder(int appointmentId, string reminderTime)
        {
            try
            {
                reminder newReminder = new reminder()
                {
                    appointment_id = appointmentId,
                    minutes_before = reminderTime
                };
                entity.reminders.Add(newReminder);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                return false;
            }
        }

        public bool joinGroupMeeting(int appointmentId)
        {
            try
            {
                member newMember = new member()
                {
                    appointment_id = appointmentId,
                    user_id = userID
                };
                entity.members.Add(newMember);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                return false;
            }
        }

        public bool removeAppointment(int appointmentId)
        {
            try
            {
                var appointment = entity.appointments.Find(appointmentId);
                if (appointment != null)
                {
                    if (appointment.is_group_meeting == true
                        && userID != appointment.user_id)
                    {
                        //xoá user khỏi cuộc họp nhóm
                        leaveGroupMeeting(appointmentId);
                        return true;
                    }
                    else if(appointment.is_group_meeting == true
                        && userID == appointment.user_id)
                    {
                        //xoá tất cả thành viên khỏi cuộc họp nhóm
                        var members = entity.members.Where(m => m.appointment_id == appointmentId).ToList();
                        foreach (var member in members)
                        {
                            entity.members.Remove(member);
                        }
                    }

                    // Xoá các reminder liên quan đến cuộc hẹn
                    var reminders = entity.reminders.Where(r => r.appointment_id == appointmentId).ToList();
                    foreach (var reminder in reminders)
                    {
                        entity.reminders.Remove(reminder);
                    }

                    entity.appointments.Remove(appointment);
                    entity.SaveChanges();
                    return true;
                }
                return false; // Không tìm thấy cuộc hẹn
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                return false;
            }
        }

        public bool leaveGroupMeeting(int appointmentId)
        {
            try
            {
                var member = entity.members.FirstOrDefault(m => m.appointment_id == appointmentId && m.user_id == userID);
                if (member != null)
                {
                    entity.members.Remove(member);
                    entity.SaveChanges();
                    return true;
                }
                return false; // Không tìm thấy thành viên trong cuộc họp nhóm
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                return false;
            }
        }

    }
}
