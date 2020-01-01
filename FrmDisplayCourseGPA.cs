using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DepartmentManagement.Services;

namespace DepartmentManagement
{
    public partial class FrmDisplayCourseGPA : Form
    {
        Add add = new Add();
        public FrmDisplayCourseGPA()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmDisplayCourseGPA_Load(object sender, EventArgs e)
        {
            LoadCourseGPA();

        }

        public void LoadCourseGPA()
        {
            Add add = new Add();
            ArrayList list = new ArrayList();
            list = add.GetCourseGPA();
            lvDisplayCourseGPA.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem((list[i] as Add).Roll);

                // item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Session);
                item.SubItems.Add((list[i] as Add).Year);
                item.SubItems.Add((list[i] as Add).Semester);
                item.SubItems.Add((list[i] as Add).Course_code);
                item.SubItems.Add((list[i] as Add).Course_credit);
                item.SubItems.Add((list[i] as Add).Gpa);
                item.SubItems.Add((list[i] as Add).Gpa_history);


                lvDisplayCourseGPA.Items.Add(item);
            }


        }
    }
}
