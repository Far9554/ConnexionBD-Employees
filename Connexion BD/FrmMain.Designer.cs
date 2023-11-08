namespace Connexion_BD
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UDSelectMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.UDSelectMax = new System.Windows.Forms.NumericUpDown();
            this.cbAllJobs = new System.Windows.Forms.CheckBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.btSelectEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tcView = new System.Windows.Forms.TabControl();
            this.Jobs = new System.Windows.Forms.TabPage();
            this.Employees = new System.Windows.Forms.TabPage();
            this.cbSelec_Location = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSelect_LastName_Employee = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSelect_FirstName_Employee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWarningInsert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UdMin = new System.Windows.Forms.NumericUpDown();
            this.UdMax = new System.Windows.Forms.NumericUpDown();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UDSelectMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSelectMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tcView.SuspendLayout();
            this.Jobs.SuspendLayout();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(372, 460);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(180, 52);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(576, 460);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(180, 52);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Min:";
            // 
            // UDSelectMin
            // 
            this.UDSelectMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UDSelectMin.Location = new System.Drawing.Point(789, 373);
            this.UDSelectMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UDSelectMin.Name = "UDSelectMin";
            this.UDSelectMin.Size = new System.Drawing.Size(94, 22);
            this.UDSelectMin.TabIndex = 14;
            this.UDSelectMin.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max:";
            // 
            // UDSelectMax
            // 
            this.UDSelectMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UDSelectMax.Location = new System.Drawing.Point(940, 373);
            this.UDSelectMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UDSelectMax.Name = "UDSelectMax";
            this.UDSelectMax.Size = new System.Drawing.Size(94, 22);
            this.UDSelectMax.TabIndex = 12;
            this.UDSelectMax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbAllJobs
            // 
            this.cbAllJobs.AutoSize = true;
            this.cbAllJobs.Checked = true;
            this.cbAllJobs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllJobs.Location = new System.Drawing.Point(660, 375);
            this.cbAllJobs.Name = "cbAllJobs";
            this.cbAllJobs.Size = new System.Drawing.Size(43, 20);
            this.cbAllJobs.TabIndex = 11;
            this.cbAllJobs.Text = "all";
            this.cbAllJobs.UseVisualStyleBackColor = true;
            this.cbAllJobs.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // btSelect
            // 
            this.btSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelect.Location = new System.Drawing.Point(558, 364);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(96, 36);
            this.btSelect.TabIndex = 9;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToResizeColumns = false;
            this.dgvJobs.AllowUserToResizeRows = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(540, 3);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(515, 355);
            this.dgvJobs.TabIndex = 10;
            // 
            // btSelectEmployee
            // 
            this.btSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectEmployee.Location = new System.Drawing.Point(537, 367);
            this.btSelectEmployee.Name = "btSelectEmployee";
            this.btSelectEmployee.Size = new System.Drawing.Size(96, 36);
            this.btSelectEmployee.TabIndex = 9;
            this.btSelectEmployee.Text = "Select";
            this.btSelectEmployee.UseVisualStyleBackColor = true;
            this.btSelectEmployee.Click += new System.EventHandler(this.btSelectEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(6, 6);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1046, 236);
            this.dgvEmployee.TabIndex = 10;
            // 
            // tcView
            // 
            this.tcView.Controls.Add(this.Jobs);
            this.tcView.Controls.Add(this.Employees);
            this.tcView.Location = new System.Drawing.Point(12, 12);
            this.tcView.Name = "tcView";
            this.tcView.SelectedIndex = 0;
            this.tcView.Size = new System.Drawing.Size(1069, 441);
            this.tcView.TabIndex = 17;
            // 
            // Jobs
            // 
            this.Jobs.Controls.Add(this.label5);
            this.Jobs.Controls.Add(this.UDSelectMin);
            this.Jobs.Controls.Add(this.dgvJobs);
            this.Jobs.Controls.Add(this.label4);
            this.Jobs.Controls.Add(this.tbName);
            this.Jobs.Controls.Add(this.UDSelectMax);
            this.Jobs.Controls.Add(this.btInsert);
            this.Jobs.Controls.Add(this.cbAllJobs);
            this.Jobs.Controls.Add(this.UdMax);
            this.Jobs.Controls.Add(this.btSelect);
            this.Jobs.Controls.Add(this.UdMin);
            this.Jobs.Controls.Add(this.label1);
            this.Jobs.Controls.Add(this.lbWarningInsert);
            this.Jobs.Controls.Add(this.label2);
            this.Jobs.Controls.Add(this.label3);
            this.Jobs.Location = new System.Drawing.Point(4, 25);
            this.Jobs.Name = "Jobs";
            this.Jobs.Padding = new System.Windows.Forms.Padding(3);
            this.Jobs.Size = new System.Drawing.Size(1061, 412);
            this.Jobs.TabIndex = 0;
            this.Jobs.Text = "Jobs";
            this.Jobs.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.cbSelec_Location);
            this.Employees.Controls.Add(this.label16);
            this.Employees.Controls.Add(this.tbSelect_LastName_Employee);
            this.Employees.Controls.Add(this.label15);
            this.Employees.Controls.Add(this.tbSelect_FirstName_Employee);
            this.Employees.Controls.Add(this.label14);
            this.Employees.Controls.Add(this.dgvEmployee);
            this.Employees.Controls.Add(this.btSelectEmployee);
            this.Employees.Location = new System.Drawing.Point(4, 25);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(1061, 412);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // cbSelec_Location
            // 
            this.cbSelec_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelec_Location.FormattingEnabled = true;
            this.cbSelec_Location.Location = new System.Drawing.Point(642, 304);
            this.cbSelec_Location.Name = "cbSelec_Location";
            this.cbSelec_Location.Size = new System.Drawing.Size(410, 24);
            this.cbSelec_Location.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(534, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Location:";
            // 
            // tbSelect_LastName_Employee
            // 
            this.tbSelect_LastName_Employee.Location = new System.Drawing.Point(642, 276);
            this.tbSelect_LastName_Employee.Name = "tbSelect_LastName_Employee";
            this.tbSelect_LastName_Employee.Size = new System.Drawing.Size(410, 22);
            this.tbSelect_LastName_Employee.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(533, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Last Name:";
            // 
            // tbSelect_FirstName_Employee
            // 
            this.tbSelect_FirstName_Employee.Location = new System.Drawing.Point(642, 248);
            this.tbSelect_FirstName_Employee.Name = "tbSelect_FirstName_Employee";
            this.tbSelect_FirstName_Employee.Size = new System.Drawing.Size(410, 22);
            this.tbSelect_FirstName_Employee.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min Salary:";
            // 
            // lbWarningInsert
            // 
            this.lbWarningInsert.AutoSize = true;
            this.lbWarningInsert.Location = new System.Drawing.Point(16, 108);
            this.lbWarningInsert.Name = "lbWarningInsert";
            this.lbWarningInsert.Size = new System.Drawing.Size(57, 16);
            this.lbWarningInsert.TabIndex = 7;
            this.lbWarningInsert.Text = "Warning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job Title:";
            // 
            // UdMin
            // 
            this.UdMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UdMin.Location = new System.Drawing.Point(111, 35);
            this.UdMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UdMin.Name = "UdMin";
            this.UdMin.Size = new System.Drawing.Size(94, 22);
            this.UdMin.TabIndex = 4;
            this.UdMin.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // UdMax
            // 
            this.UdMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UdMax.Location = new System.Drawing.Point(111, 63);
            this.UdMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UdMax.Name = "UdMax";
            this.UdMax.Size = new System.Drawing.Size(94, 22);
            this.UdMax.TabIndex = 5;
            this.UdMax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(12, 134);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(96, 36);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(410, 22);
            this.tbName.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 520);
            this.Controls.Add(this.tcView);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConnect);
            this.Name = "FrmMain";
            this.Text = " Employees Editor";
            ((System.ComponentModel.ISupportInitialize)(this.UDSelectMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSelectMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tcView.ResumeLayout(false);
            this.Jobs.ResumeLayout(false);
            this.Jobs.PerformLayout();
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.CheckBox cbAllJobs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UDSelectMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown UDSelectMax;
        private System.Windows.Forms.Button btSelectEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TabControl tcView;
        private System.Windows.Forms.TabPage Jobs;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.TextBox tbSelect_FirstName_Employee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSelect_LastName_Employee;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSelec_Location;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.NumericUpDown UdMax;
        private System.Windows.Forms.NumericUpDown UdMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWarningInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

