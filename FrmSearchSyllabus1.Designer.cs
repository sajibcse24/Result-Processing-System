namespace DepartmentManagement
{
    partial class FrmSearchSyllabus1
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmYear = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSearchSyllabus = new System.Windows.Forms.ListView();
            this.course_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course_credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Location = new System.Drawing.Point(18, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 60);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(10, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Location = new System.Drawing.Point(116, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmSemester);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmYear);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmSemester
            // 
            this.cmSemester.FormattingEnabled = true;
            this.cmSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmSemester.Location = new System.Drawing.Point(107, 52);
            this.cmSemester.Name = "cmSemester";
            this.cmSemester.Size = new System.Drawing.Size(47, 21);
            this.cmSemester.TabIndex = 16;
            this.cmSemester.SelectedIndexChanged += new System.EventHandler(this.cmSemester_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Year";
            // 
            // cmYear
            // 
            this.cmYear.FormattingEnabled = true;
            this.cmYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmYear.Location = new System.Drawing.Point(107, 19);
            this.cmYear.Name = "cmYear";
            this.cmYear.Size = new System.Drawing.Size(47, 21);
            this.cmYear.TabIndex = 0;
            this.cmYear.SelectedIndexChanged += new System.EventHandler(this.cmYear_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvSearchSyllabus);
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 199);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lvSearchSyllabus
            // 
            this.lvSearchSyllabus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.course_code,
            this.course_title,
            this.course_credit,
            this.year,
            this.semester});
            this.lvSearchSyllabus.GridLines = true;
            this.lvSearchSyllabus.Location = new System.Drawing.Point(8, 15);
            this.lvSearchSyllabus.Name = "lvSearchSyllabus";
            this.lvSearchSyllabus.Size = new System.Drawing.Size(597, 168);
            this.lvSearchSyllabus.TabIndex = 3;
            this.lvSearchSyllabus.UseCompatibleStateImageBehavior = false;
            this.lvSearchSyllabus.View = System.Windows.Forms.View.Details;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(39, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmSearchSyllabus1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(962, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSearchSyllabus1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syllabus Search Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmYear;
        private System.Windows.Forms.ComboBox cmSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvSearchSyllabus;
        private System.Windows.Forms.ColumnHeader course_code;
        private System.Windows.Forms.ColumnHeader course_title;
        private System.Windows.Forms.ColumnHeader course_credit;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}