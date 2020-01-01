using DepartmentManagement;
namespace DepartmentManagement
{
    partial class FrmDispaly
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
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.roll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.psession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registration_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blood_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mobile_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.lvDisplay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lvDisplay
            // 
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roll,
            this.name,
            this.session,
            this.psession,
            this.registration_no,
            this.sex,
            this.blood_group,
            this.mobile_no,
            this.email});
            this.lvDisplay.GridLines = true;
            this.lvDisplay.Location = new System.Drawing.Point(9, 10);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(680, 252);
            this.lvDisplay.TabIndex = 1;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            this.lvDisplay.SelectedIndexChanged += new System.EventHandler(this.lvDisplay_SelectedIndexChanged);
            // 
            // roll
            // 
            this.roll.Text = "Roll";
            this.roll.Width = 80;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // session
            // 
            this.session.Text = "Session";
            this.session.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session.Width = 80;
            // 
            // psession
            // 
            this.psession.Text = "Previous Session";
            this.psession.Width = 100;
            // 
            // registration_no
            // 
            this.registration_no.Text = "Registration No";
            this.registration_no.Width = 150;
            // 
            // sex
            // 
            this.sex.Text = "Sex";
            // 
            // blood_group
            // 
            this.blood_group.Text = "Blood Group";
            this.blood_group.Width = 90;
            // 
            // mobile_no
            // 
            this.mobile_no.Text = "Mobile Number";
            this.mobile_no.Width = 150;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(630, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(6, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Copyrights Reserved to Department of Computer Science and Engineering.\r\nComil" +
                "la University, Comilla, Bangladesh.";
            // 
            // FrmDispaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(721, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDispaly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Students Information ";
            this.Load += new System.EventHandler(this.FrmDispaly_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader roll;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader session;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader psession;
        private System.Windows.Forms.ColumnHeader registration_no;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader blood_group;
        private System.Windows.Forms.ColumnHeader mobile_no;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Label label1;
    }
}