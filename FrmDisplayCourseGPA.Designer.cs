namespace DepartmentManagement
{
    partial class FrmDisplayCourseGPA
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
            this.lvDisplayCourseGPA = new System.Windows.Forms.ListView();
            this.roll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpa_history = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDisplayCourseGPA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lvDisplayCourseGPA
            // 
            this.lvDisplayCourseGPA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roll,
            this.session,
            this.year,
            this.semester,
            this.course_code,
            this.course_credit,
            this.gpa,
            this.gpa_history});
            this.lvDisplayCourseGPA.GridLines = true;
            this.lvDisplayCourseGPA.Location = new System.Drawing.Point(6, 19);
            this.lvDisplayCourseGPA.Name = "lvDisplayCourseGPA";
            this.lvDisplayCourseGPA.Size = new System.Drawing.Size(449, 188);
            this.lvDisplayCourseGPA.TabIndex = 0;
            this.lvDisplayCourseGPA.UseCompatibleStateImageBehavior = false;
            this.lvDisplayCourseGPA.View = System.Windows.Forms.View.Details;
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
            // year
            // 
            this.year.Text = "Year";
            // 
            // semester
            // 
            this.semester.Text = "Semester";
            // 
            // course_code
            // 
            this.course_code.Text = "Course Code";
            this.course_code.Width = 80;
            // 
            // course_credit
            // 
            this.course_credit.Text = "Course Credit";
            this.course_credit.Width = 80;
            // 
            // gpa
            // 
            this.gpa.Text = "GPA";
            // 
            // gpa_history
            // 
            this.gpa_history.Text = "GPA-History";
            this.gpa_history.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(398, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 40);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Location = new System.Drawing.Point(6, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmDisplayCourseGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(531, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDisplayCourseGPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course GPA Information";
            this.Load += new System.EventHandler(this.FrmDisplayCourseGPA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDisplayCourseGPA;
        private System.Windows.Forms.ColumnHeader roll;
        private System.Windows.Forms.ColumnHeader session;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.ColumnHeader course_code;
        private System.Windows.Forms.ColumnHeader course_credit;
        private System.Windows.Forms.ColumnHeader gpa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader gpa_history;
        private System.Windows.Forms.Label label1;
    }
}