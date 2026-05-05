using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCalendarAppointment.DTO
{
    public class appointmentView
    {
        public int Id { get; set; }   // QUAN TRỌNG
        public string Title { get; set; }
        public string Time { get; set; }
    }
}
