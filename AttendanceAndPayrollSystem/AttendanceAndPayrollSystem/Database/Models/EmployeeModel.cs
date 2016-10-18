using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAndPayrollSystem.Database.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Sex { get; set; }
        public string Barangay { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Citizenship { get; set; }
        public string Religion { get; set; }
        public string CivilStatus { get; set; }

        public ICollection<EducationalAttainmentModel> EducationalAttainments { get; set; } = new List<EducationalAttainmentModel>();
    }
}
