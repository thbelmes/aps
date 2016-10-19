using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAndPayrollSystem.Database.Models
{
   public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DateTimeIn { get; set; }
        public DateTime? DateTimeOut { get; set; }
        public double? RegularHoursRendered { get; set; }
        public double? OTHoursRendered { get; set; }

    }
}
