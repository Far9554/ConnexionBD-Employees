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
            this.btInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.UdMin = new System.Windows.Forms.NumericUpDown();
            this.UdMax = new System.Windows.Forms.NumericUpDown();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.lbWarningInsert = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdMax)).BeginInit();
            this.gbInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(356, 548);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(109, 34);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(356, 590);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(109, 34);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(131, 159);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(96, 36);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(415, 27);
            this.tbName.TabIndex = 3;
            // 
            // UdMin
            // 
            this.UdMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UdMin.Location = new System.Drawing.Point(109, 60);
            this.UdMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UdMin.Name = "UdMin";
            this.UdMin.Size = new System.Drawing.Size(94, 27);
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
            this.UdMax.Location = new System.Drawing.Point(109, 88);
            this.UdMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UdMax.Name = "UdMax";
            this.UdMax.Size = new System.Drawing.Size(94, 27);
            this.UdMax.TabIndex = 5;
            this.UdMax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.btSelect);
            this.gbInsert.Controls.Add(this.dgvJobs);
            this.gbInsert.Controls.Add(this.lbWarningInsert);
            this.gbInsert.Controls.Add(this.label3);
            this.gbInsert.Controls.Add(this.label2);
            this.gbInsert.Controls.Add(this.label1);
            this.gbInsert.Controls.Add(this.UdMin);
            this.gbInsert.Controls.Add(this.UdMax);
            this.gbInsert.Controls.Add(this.btInsert);
            this.gbInsert.Controls.Add(this.tbName);
            this.gbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsert.Location = new System.Drawing.Point(12, 12);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(540, 496);
            this.gbInsert.TabIndex = 6;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "Insert Job";
            // 
            // btSelect
            // 
            this.btSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelect.Location = new System.Drawing.Point(9, 444);
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
            this.dgvJobs.Location = new System.Drawing.Point(9, 202);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(515, 236);
            this.dgvJobs.TabIndex = 10;
            // 
            // lbWarningInsert
            // 
            this.lbWarningInsert.AutoSize = true;
            this.lbWarningInsert.Location = new System.Drawing.Point(5, 134);
            this.lbWarningInsert.Name = "lbWarningInsert";
            this.lbWarningInsert.Size = new System.Drawing.Size(71, 20);
            this.lbWarningInsert.TabIndex = 7;
            this.lbWarningInsert.Text = "Warning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job Title:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 638);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConnect);
            this.Name = "FrmMain";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.UdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdMax)).EndInit();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown UdMin;
        private System.Windows.Forms.NumericUpDown UdMax;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWarningInsert;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.DataGridView dgvJobs;
    }
}

