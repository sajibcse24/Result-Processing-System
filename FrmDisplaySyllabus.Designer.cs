namespace DepartmentManagement
{
    partial class FrmDisplaySyllabus
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
            this.lvDisplaySyllabus = new System.Windows.Forms.ListView();
            this.course_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDisplaySyllabus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lvDisplaySyllabus
            // 
            this.lvDisplaySyllabus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.course_code,
            this.course_title,
            this.course_credit,
            this.year,
            this.semester});
            this.lvDisplaySyllabus.GridLines = true;
            this.lvDisplaySyllabus.Location = new System.Drawing.Point(5, 19);
            this.lvDisplaySyllabus.Name = "lvDisplaySyllabus";
            this.lvDisplaySyllabus.Size = new System.Drawing.Size(597, 168);
            this.lvDisplaySyllabus.TabIndex = 2;
            this.lvDisplaySyllabus.UseCompatibleStateImageBehavior = false;
            this.lvDisplaySyllabus.View = System.Windows.Forms.View.Details;
            // 
            // course_code
            // 
            this.course_code.Text = "Course Code";
            this.course_code.Width = 80;
            // 
            // course_title
            // 
            this.course_title.Text = "Course Title";
            this.course_title.Width = 300;
            // 
            // course_credit
            // 
            this.course_credit.Text = "Course Credit";
            this.course_credit.Width = 80;
            // 
            // year
            // 
            this.year.Text = "Year";
            // 
            // semester
            // 
            this.semester.Text = "Semester";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(533, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 40);
            this.groupBox2.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(9, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmDisplaySyllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(643, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDisplaySyllabus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syllabus Information";
            this.Load += new System.EventHandler(this.FrmDisplaySyllabus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvDisplaySyllabus;
        private System.Windows.Forms.ColumnHeader course_code;
        private System.Windows.Forms.ColumnHeader course_title;
        private System.Windows.Forms.ColumnHeader course_credit;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.Label label1;
    }
}