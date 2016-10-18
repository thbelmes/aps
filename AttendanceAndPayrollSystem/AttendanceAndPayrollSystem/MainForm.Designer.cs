namespace AttendanceAndPayrollSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.btn = new System.Windows.Forms.TabPage();
            this.btnEmpAttendance = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.gridAttendance = new System.Windows.Forms.DataGridView();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.tabPayroll = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsDataSet = new AttendanceAndPayrollSystem.apsDataSet();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularHoursRenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTHoursRenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uvwAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new AttendanceAndPayrollSystem.apsDataSetTableAdapters.EmployeesTableAdapter();
            this.uvwAttendanceTableAdapter = new AttendanceAndPayrollSystem.apsDataSetTableAdapters.uvwAttendanceTableAdapter();
            this.uvwPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uvwPayrollTableAdapter = new AttendanceAndPayrollSystem.apsDataSetTableAdapters.uvwPayrollTableAdapter();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPeriodStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPeriodEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRegularHoursRenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOTHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumSSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumPhilHealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumPagibigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumBirTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdmfLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSSLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGeneratePayroll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.btn.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).BeginInit();
            this.tabPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwPayrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMain.Controls.Add(this.btn);
            this.tabMain.Controls.Add(this.tabEmployee);
            this.tabMain.Controls.Add(this.tabAttendance);
            this.tabMain.Controls.Add(this.tabPayroll);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ItemSize = new System.Drawing.Size(26, 200);
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1341, 781);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackgroundImage = global::AttendanceAndPayrollSystem.Properties.Resources.cakes;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn.Controls.Add(this.btnEmpAttendance);
            this.btn.Controls.Add(this.btnRegistration);
            this.btn.Location = new System.Drawing.Point(204, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(1133, 773);
            this.btn.TabIndex = 2;
            this.btn.Text = "H O M E";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnEmpAttendance
            // 
            this.btnEmpAttendance.BackColor = System.Drawing.Color.White;
            this.btnEmpAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpAttendance.Image = global::AttendanceAndPayrollSystem.Properties.Resources.clock;
            this.btnEmpAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpAttendance.Location = new System.Drawing.Point(869, 254);
            this.btnEmpAttendance.Name = "btnEmpAttendance";
            this.btnEmpAttendance.Size = new System.Drawing.Size(187, 149);
            this.btnEmpAttendance.TabIndex = 1;
            this.btnEmpAttendance.Text = "Employee Attendance";
            this.btnEmpAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpAttendance.UseVisualStyleBackColor = false;
            this.btnEmpAttendance.Click += new System.EventHandler(this.btnEmpAttendance_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.BackgroundImage = global::AttendanceAndPayrollSystem.Properties.Resources.people;
            this.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistration.Location = new System.Drawing.Point(869, 91);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(187, 149);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Employee Registration";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnNewEmployee);
            this.tabEmployee.Controls.Add(this.gridEmployees);
            this.tabEmployee.Location = new System.Drawing.Point(204, 4);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1133, 773);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // gridEmployees
            // 
            this.gridEmployees.AutoGenerateColumns = false;
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.gridEmployees.DataSource = this.employeesBindingSource;
            this.gridEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gridEmployees.Location = new System.Drawing.Point(3, 74);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(1127, 696);
            this.gridEmployees.TabIndex = 0;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.gridAttendance);
            this.tabAttendance.Location = new System.Drawing.Point(204, 4);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(1133, 773);
            this.tabAttendance.TabIndex = 1;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // gridAttendance
            // 
            this.gridAttendance.AutoGenerateColumns = false;
            this.gridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dateTimeInDataGridViewTextBoxColumn,
            this.dateTimeOutDataGridViewTextBoxColumn,
            this.regularHoursRenderedDataGridViewTextBoxColumn,
            this.oTHoursRenderedDataGridViewTextBoxColumn});
            this.gridAttendance.DataSource = this.uvwAttendanceBindingSource;
            this.gridAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAttendance.Location = new System.Drawing.Point(3, 75);
            this.gridAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.gridAttendance.Name = "gridAttendance";
            this.gridAttendance.RowHeadersWidth = 40;
            this.gridAttendance.RowTemplate.Height = 24;
            this.gridAttendance.Size = new System.Drawing.Size(1127, 695);
            this.gridAttendance.TabIndex = 0;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(981, 34);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(144, 34);
            this.btnNewEmployee.TabIndex = 1;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // tabPayroll
            // 
            this.tabPayroll.Controls.Add(this.btnGeneratePayroll);
            this.tabPayroll.Controls.Add(this.dataGridView1);
            this.tabPayroll.Location = new System.Drawing.Point(204, 4);
            this.tabPayroll.Name = "tabPayroll";
            this.tabPayroll.Size = new System.Drawing.Size(1133, 773);
            this.tabPayroll.TabIndex = 3;
            this.tabPayroll.Text = "Payroll";
            this.tabPayroll.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.payrollIdDataGridViewTextBoxColumn,
            this.payPeriodStartDataGridViewTextBoxColumn,
            this.payPeriodEndDataGridViewTextBoxColumn,
            this.dailyRateDataGridViewTextBoxColumn,
            this.totalRegularHoursRenderedDataGridViewTextBoxColumn,
            this.totalOTHoursDataGridViewTextBoxColumn,
            this.premiumSSSDataGridViewTextBoxColumn,
            this.premiumPhilHealthDataGridViewTextBoxColumn,
            this.premiumPagibigDataGridViewTextBoxColumn,
            this.premiumBirTaxDataGridViewTextBoxColumn,
            this.hdmfLoanDataGridViewTextBoxColumn,
            this.sSSLoanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uvwPayrollBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1133, 696);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn4.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthdate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Birthdate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Barangay";
            this.dataGridViewTextBoxColumn7.HeaderText = "Barangay";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn8.HeaderText = "Street";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn9.HeaderText = "City";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Citizenship";
            this.dataGridViewTextBoxColumn10.HeaderText = "Citizenship";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Religion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Religion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CivilStatus";
            this.dataGridViewTextBoxColumn12.HeaderText = "CivilStatus";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.apsDataSet;
            // 
            // apsDataSet
            // 
            this.apsDataSet.DataSetName = "apsDataSet";
            this.apsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn13.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn14.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn15.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dateTimeInDataGridViewTextBoxColumn
            // 
            this.dateTimeInDataGridViewTextBoxColumn.DataPropertyName = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.HeaderText = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.Name = "dateTimeInDataGridViewTextBoxColumn";
            // 
            // dateTimeOutDataGridViewTextBoxColumn
            // 
            this.dateTimeOutDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.HeaderText = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.Name = "dateTimeOutDataGridViewTextBoxColumn";
            // 
            // regularHoursRenderedDataGridViewTextBoxColumn
            // 
            this.regularHoursRenderedDataGridViewTextBoxColumn.DataPropertyName = "RegularHoursRendered";
            this.regularHoursRenderedDataGridViewTextBoxColumn.HeaderText = "RegularHoursRendered";
            this.regularHoursRenderedDataGridViewTextBoxColumn.Name = "regularHoursRenderedDataGridViewTextBoxColumn";
            // 
            // oTHoursRenderedDataGridViewTextBoxColumn
            // 
            this.oTHoursRenderedDataGridViewTextBoxColumn.DataPropertyName = "OTHoursRendered";
            this.oTHoursRenderedDataGridViewTextBoxColumn.HeaderText = "OTHoursRendered";
            this.oTHoursRenderedDataGridViewTextBoxColumn.Name = "oTHoursRenderedDataGridViewTextBoxColumn";
            // 
            // uvwAttendanceBindingSource
            // 
            this.uvwAttendanceBindingSource.DataMember = "uvwAttendance";
            this.uvwAttendanceBindingSource.DataSource = this.apsDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // uvwAttendanceTableAdapter
            // 
            this.uvwAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // uvwPayrollBindingSource
            // 
            this.uvwPayrollBindingSource.DataMember = "uvwPayroll";
            this.uvwPayrollBindingSource.DataSource = this.apsDataSet;
            // 
            // uvwPayrollTableAdapter
            // 
            this.uvwPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn16.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn17.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn18.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // payrollIdDataGridViewTextBoxColumn
            // 
            this.payrollIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollId";
            this.payrollIdDataGridViewTextBoxColumn.HeaderText = "PayrollId";
            this.payrollIdDataGridViewTextBoxColumn.Name = "payrollIdDataGridViewTextBoxColumn";
            this.payrollIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payPeriodStartDataGridViewTextBoxColumn
            // 
            this.payPeriodStartDataGridViewTextBoxColumn.DataPropertyName = "PayPeriodStart";
            this.payPeriodStartDataGridViewTextBoxColumn.HeaderText = "PayPeriodStart";
            this.payPeriodStartDataGridViewTextBoxColumn.Name = "payPeriodStartDataGridViewTextBoxColumn";
            // 
            // payPeriodEndDataGridViewTextBoxColumn
            // 
            this.payPeriodEndDataGridViewTextBoxColumn.DataPropertyName = "PayPeriodEnd";
            this.payPeriodEndDataGridViewTextBoxColumn.HeaderText = "PayPeriodEnd";
            this.payPeriodEndDataGridViewTextBoxColumn.Name = "payPeriodEndDataGridViewTextBoxColumn";
            // 
            // dailyRateDataGridViewTextBoxColumn
            // 
            this.dailyRateDataGridViewTextBoxColumn.DataPropertyName = "DailyRate";
            this.dailyRateDataGridViewTextBoxColumn.HeaderText = "DailyRate";
            this.dailyRateDataGridViewTextBoxColumn.Name = "dailyRateDataGridViewTextBoxColumn";
            // 
            // totalRegularHoursRenderedDataGridViewTextBoxColumn
            // 
            this.totalRegularHoursRenderedDataGridViewTextBoxColumn.DataPropertyName = "TotalRegularHoursRendered";
            this.totalRegularHoursRenderedDataGridViewTextBoxColumn.HeaderText = "TotalRegularHoursRendered";
            this.totalRegularHoursRenderedDataGridViewTextBoxColumn.Name = "totalRegularHoursRenderedDataGridViewTextBoxColumn";
            // 
            // totalOTHoursDataGridViewTextBoxColumn
            // 
            this.totalOTHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalOTHours";
            this.totalOTHoursDataGridViewTextBoxColumn.HeaderText = "TotalOTHours";
            this.totalOTHoursDataGridViewTextBoxColumn.Name = "totalOTHoursDataGridViewTextBoxColumn";
            // 
            // premiumSSSDataGridViewTextBoxColumn
            // 
            this.premiumSSSDataGridViewTextBoxColumn.DataPropertyName = "PremiumSSS";
            this.premiumSSSDataGridViewTextBoxColumn.HeaderText = "PremiumSSS";
            this.premiumSSSDataGridViewTextBoxColumn.Name = "premiumSSSDataGridViewTextBoxColumn";
            // 
            // premiumPhilHealthDataGridViewTextBoxColumn
            // 
            this.premiumPhilHealthDataGridViewTextBoxColumn.DataPropertyName = "PremiumPhilHealth";
            this.premiumPhilHealthDataGridViewTextBoxColumn.HeaderText = "PremiumPhilHealth";
            this.premiumPhilHealthDataGridViewTextBoxColumn.Name = "premiumPhilHealthDataGridViewTextBoxColumn";
            // 
            // premiumPagibigDataGridViewTextBoxColumn
            // 
            this.premiumPagibigDataGridViewTextBoxColumn.DataPropertyName = "PremiumPagibig";
            this.premiumPagibigDataGridViewTextBoxColumn.HeaderText = "PremiumPagibig";
            this.premiumPagibigDataGridViewTextBoxColumn.Name = "premiumPagibigDataGridViewTextBoxColumn";
            // 
            // premiumBirTaxDataGridViewTextBoxColumn
            // 
            this.premiumBirTaxDataGridViewTextBoxColumn.DataPropertyName = "PremiumBirTax";
            this.premiumBirTaxDataGridViewTextBoxColumn.HeaderText = "PremiumBirTax";
            this.premiumBirTaxDataGridViewTextBoxColumn.Name = "premiumBirTaxDataGridViewTextBoxColumn";
            // 
            // hdmfLoanDataGridViewTextBoxColumn
            // 
            this.hdmfLoanDataGridViewTextBoxColumn.DataPropertyName = "HdmfLoan";
            this.hdmfLoanDataGridViewTextBoxColumn.HeaderText = "HdmfLoan";
            this.hdmfLoanDataGridViewTextBoxColumn.Name = "hdmfLoanDataGridViewTextBoxColumn";
            // 
            // sSSLoanDataGridViewTextBoxColumn
            // 
            this.sSSLoanDataGridViewTextBoxColumn.DataPropertyName = "SSSLoan";
            this.sSSLoanDataGridViewTextBoxColumn.HeaderText = "SSSLoan";
            this.sSSLoanDataGridViewTextBoxColumn.Name = "sSSLoanDataGridViewTextBoxColumn";
            // 
            // btnGeneratePayroll
            // 
            this.btnGeneratePayroll.Location = new System.Drawing.Point(981, 37);
            this.btnGeneratePayroll.Name = "btnGeneratePayroll";
            this.btnGeneratePayroll.Size = new System.Drawing.Size(144, 34);
            this.btnGeneratePayroll.TabIndex = 2;
            this.btnGeneratePayroll.Text = "Generate Payroll";
            this.btnGeneratePayroll.UseVisualStyleBackColor = true;
            this.btnGeneratePayroll.Click += new System.EventHandler(this.btnGeneratePayroll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 805);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance and Payroll System v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.btn.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).EndInit();
            this.tabPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwPayrollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage btn;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.DataGridView gridAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilStatusDataGridViewTextBoxColumn;
        private apsDataSet apsDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private apsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource uvwAttendanceBindingSource;
        private apsDataSetTableAdapters.uvwAttendanceTableAdapter uvwAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularHoursRenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHoursRenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEmpAttendance;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.TabPage tabPayroll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource uvwPayrollBindingSource;
        private apsDataSetTableAdapters.uvwPayrollTableAdapter uvwPayrollTableAdapter;
        private System.Windows.Forms.Button btnGeneratePayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPeriodStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPeriodEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRegularHoursRenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOTHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumSSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumPhilHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumPagibigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumBirTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdmfLoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSSLoanDataGridViewTextBoxColumn;
    }
}

