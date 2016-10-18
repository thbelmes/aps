using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAndPayrollSystem.Database.Models
{
    public class EducationalAttainmentModel
    {
        public int EducationalAttainmentId { get; set; }
        public int EmployeeId { get; set; }
        public string SchoolAttended { get; set; }
        public string YearGraduated { get; set; }
        public string Qualification { get; set; }
    }
}
