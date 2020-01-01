namespace DepartmentManagement
{
    partial class FrmSearchTeachersByDesignation
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
            this.cmDesignation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSearchTeachersByDesignation = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateofjoin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blood_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mobile_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmDesignation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmDesignation
            // 
            this.cmDesignation.FormattingEnabled = true;
            this.cmDesignation.Items.AddRange(new object[] {
            "Lecturer",
            "Assistant Professor",
            "Associate Professor",
            "Professor"});
            this.cmDesignation.Location = new System.Drawing.Point(108, 13);
            this.cmDesignation.Name = "cmDesignation";
            this.cmDesignation.Size = new System.Drawing.Size(129, 21);
            this.cmDesignation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Designation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvSearchTeachersByDesignation);
            this.groupBox3.Location = new System.Drawing.Point(344, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 288);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lvSearchTeachersByDesignation
            // 
            this.lvSearchTeachersByDesignation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.designation,
            this.dateofjoin,
            this.blood_group,
            this.mobile_no,
            this.email});
            this.lvSearchTeachersByDesignation.GridLines = true;
            this.lvSearchTeachersByDesignation.Location = new System.Drawing.Point(6, 19);
            this.lvSearchTeachersByDesignation.Name = "lvSearchTeachersByDesignation";
            this.lvSearchTeachersByDesignation.Size = new System.Drawing.Size(681, 252);
            this.lvSearchTeachersByDesignation.TabIndex = 2;
            this.lvSearchTeachersByDesignation.UseCompatibleStateImageBehavior = false;
            this.lvSearchTeachersByDesignation.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.designation.Width = 120;
            // 
            // dateofjoin
            // 
            this.dateofjoin.Text = "Date Of Join";
            this.dateofjoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateofjoin.Width = 120;
            // 
            // blood_group
            // 
            this.blood_group.Text = "Bood Group";
            this.blood_group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.blood_group.Width = 80;
            // 
            // mobile_no
            // 
            this.mobile_no.Text = "Mobile No";
            this.mobile_no.Width = 90;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Location = new System.Drawing.Point(17, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 43);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(6, 14);
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
            this.btnExit.Location = new System.Drawing.Point(172, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmSearchTeachersByDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1072, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmSearchTeachersByDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers Search Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmDesignation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvSearchTeachersByDesignation;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader dateofjoin;
        private System.Windows.Forms.ColumnHeader blood_group;
        private System.Windows.Forms.ColumnHeader mobile_no;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}