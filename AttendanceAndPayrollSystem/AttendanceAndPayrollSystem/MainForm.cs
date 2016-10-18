using AttendanceAndPayrollSystem.Database;
using AttendanceAndPayrollSystem.Payroll;
using AttendanceAndPayrollSystem.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceAndPayrollSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tabMain.DrawItem += TabMain_DrawItem;
            tabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
             // LOAD GRID
            if (((TabControl)sender).SelectedIndex == 1)
                this.employeesTableAdapter.Fill(this.apsDataSet.Employees);
            else if (((TabControl)sender).SelectedIndex == 2)
                this.uvwAttendanceTableAdapter.Fill(this.apsDataSet.uvwAttendance);
        }

        private void TabMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabMain.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabMain.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Tahoma", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            using (var registrationForm = new RegistrationForm())
            {
                registrationForm.ShowDialog();
            }
        }

        private void btnEmpAttendance_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 2;
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            using (var registrationForm = new RegistrationForm())
            {
                registrationForm.ShowDialog();
                this.employeesTableAdapter.Fill(this.apsDataSet.Employees);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apsDataSet.uvwPayroll' table. You can move, or remove it, as needed.
            this.uvwPayrollTableAdapter.Fill(this.apsDataSet.uvwPayroll);

        }

        private void btnGeneratePayroll_Click(object sender, EventArgs e)
        {
            Payroll.PayrollForm p = new PayrollForm();
            p.Show();
        }
    }
}
