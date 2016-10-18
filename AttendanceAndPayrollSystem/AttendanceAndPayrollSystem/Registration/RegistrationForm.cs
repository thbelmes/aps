using AttendanceAndPayrollSystem.Database;
using AttendanceAndPayrollSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceAndPayrollSystem.Registration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            cboCivilStatus.SelectedIndex = 0;
            cboCitizenship.SelectedIndex = 0;
            cboElemGrad.SelectedIndex = 0;
            cboHsGrad.SelectedIndex = 0;
            cboCollegeGrad.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO : VALIDATION
            var model = new EmployeeModel
            {
                LastName = txtSurname.Text,
                FirstName = txtFirstname.Text,
                MiddleName = txtMiddlename.Text,
                Birthdate = dtDob.Value,
                Sex = rbMale.Checked ? "Male" : "Female",
                Barangay = txtBarangay.Text,
                Street = txtStreet.Text,
                City = txtCity.Text,
                Citizenship = cboCitizenship.SelectedItem.ToString(),
                CivilStatus = cboCivilStatus.SelectedItem.ToString(),
                Religion = txtReligion.Text
            };

            if (!string.IsNullOrEmpty(txtElementary.Text))
                model.EducationalAttainments.Add(new EducationalAttainmentModel
                {
                    SchoolAttended = txtElementary.Text,
                    YearGraduated = cboElemGrad.SelectedItem.ToString(),
                    Qualification = txtElemRemarks.Text
                });
            if (!string.IsNullOrEmpty(txtHighSchool.Text))
                model.EducationalAttainments.Add(new EducationalAttainmentModel
                {
                    SchoolAttended = txtHighSchool.Text,
                    YearGraduated = cboHsGrad.SelectedItem.ToString(),
                    Qualification = txtHsRemarks.Text
                });
            if (!string.IsNullOrEmpty(txtCollege.Text))
                model.EducationalAttainments.Add(new EducationalAttainmentModel
                {
                    SchoolAttended = txtCollege.Text,
                    YearGraduated = cboCollegeGrad.SelectedItem.ToString(),
                    Qualification = txtCollegeRemarks.Text
                });

            var employee = new EmployeeRepository();
            if (employee.Create(model) == -1)
                MessageBox.Show("Failed on saving record");
            else
            {
                MessageBox.Show("Successfully saved!");
                txtSurname.ResetText();
                txtFirstname.ResetText();
                txtMiddlename.ResetText();
                dtDob.ResetText();
                rbMale.Checked = !(rbFemale.Checked = false);
                txtBarangay.ResetText();
                txtStreet.ResetText();
                txtCity.ResetText();
                cboCitizenship.SelectedIndex = 0;
                cboCivilStatus.SelectedIndex = 0;
                txtReligion.ResetText();

                txtElementary.ResetText();
                cboElemGrad.SelectedIndex = 0;
                txtElemRemarks.ResetText();

                txtHighSchool.ResetText();
                cboHsGrad.SelectedIndex = 0;
                txtHsRemarks.ResetText();

                txtCollege.ResetText();
                cboCollegeGrad.SelectedIndex = 0;
                txtCollegeRemarks.ResetText();
            }

        }
    }
}
