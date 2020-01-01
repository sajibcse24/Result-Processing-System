namespace DepartmentManagement
{
    partial class FrmDisplayCGPA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDisplayCGPA = new System.Windows.Forms.ListView();
            this.roll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cgpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDisplayCGPA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lvDisplayCGPA
            // 
            this.lvDisplayCGPA.BackColor = System.Drawing.SystemColors.Window;
            this.lvDisplayCGPA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roll,
            this.session,
            this.psession,
            this.cgpa,
            this.total_credit,
            this.remarks});
            this.lvDisplayCGPA.GridLines = true;
            this.lvDisplayCGPA.Location = new System.Drawing.Point(6, 19);
            this.lvDisplayCGPA.Name = "lvDisplayCGPA";
            this.lvDisplayCGPA.Size = new System.Drawing.Size(509, 207);
            this.lvDisplayCGPA.TabIndex = 0;
            this.lvDisplayCGPA.UseCompatibleStateImageBehavior = false;
            this.lvDisplayCGPA.View = System.Windows.Forms.View.Details;
            // 
            // roll
            // 
            this.roll.Text = "Roll";
            this.roll.Width = 80;
            // 
            // session
            // 
            this.session.Text = "Session";
            this.session.Width = 80;
            // 
            // psession
            // 
            this.psession.Text = "Previous Session";
            this.psession.Width = 100;
            // 
            // cgpa
            // 
            this.cgpa.Text = "CGPA";
            // 
            // total_credit
            // 
            this.total_credit.Text = "Total Credit Hour";
            this.total_credit.Width = 100;
            // 
            // remarks
            // 
            this.remarks.Text = "Remarks";
            this.remarks.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(447, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(6, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmDisplayCGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(548, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDisplayCGPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Students CGPA ";
            this.Load += new System.EventHandler(this.FrmDisplayCGPA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDisplayCGPA;
        private System.Windows.Forms.ColumnHeader roll;
        private System.Windows.Forms.ColumnHeader session;
        private System.Windows.Forms.ColumnHeader cgpa;
        private System.Windows.Forms.ColumnHeader total_credit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader remarks;
        private System.Windows.Forms.ColumnHeader psession;
    }
}