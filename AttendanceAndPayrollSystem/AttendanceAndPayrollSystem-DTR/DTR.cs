using AttendanceAndPayrollSystem;
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


namespace AttendanceAndPayrollSystem_DTR
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();

            timer.Tick += Timer_Tick; //event binding
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:hh : mm : ss tt}", DateTime.Now);
            lblDate.Text = string.Format("{0:MMMM dd, yyyy}", DateTime.Today);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(87, 216);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(779, 116);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "HH : MM : SS PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightCyan;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(360, 496);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 93);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Time In/Out";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(413, 462);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(140, 19);
            this.EmployeeID.TabIndex = 2;
            this.EmployeeID.Text = "Enter Employee Id";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(335, 414);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(300, 46);
            this.txtEmployeeID.TabIndex = 1;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(208, 99);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(512, 73);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "YYYY - MM - DD";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Attendance
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AttendanceAndPayrollSystem_DTR.Properties.Resources.cakes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 685);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            var empId = Convert.ToInt32(txtEmployeeID.Text);
            

            var model = new AttendanceModel();
            model.EmployeeId = empId;

            var repo = new AttendanceRepository();

            var attendance = repo.GetLastRecord(empId);
            var currentDate = DateTime.Now;
            if (attendance != null && attendance.DateTimeOut == null)
            {
                model.DateTimeOut = currentDate;
                model.RegularHoursRendered = currentDate.Subtract(attendance.DateTimeIn.Value).TotalHours;
                model.OTHoursRendered = 0;
                if (currentDate.Hour > 17)
                    model.OTHoursRendered = currentDate.Hour - 17;

                if (repo.TimeOut(model) != -1)
                {
                    MessageBox.Show("You have timed out", "APS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    return;
                }
            }
            else
            {
                model.DateTimeIn = currentDate;
                if (repo.TimeIn(model) != -1)
                {
                    MessageBox.Show("You have timed in", "APS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    return;
                }
            }

            // if we reach here, there's an error
            MessageBox.Show("Error in logging in/out!", "APS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Reset()
        {
            txtEmployeeID.ResetText();
            txtEmployeeID.Focus();
        }
    }
}
