using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DepartmentManagement.Services;
using System.Collections;

namespace DepartmentManagement
{
    public partial class FrmDisplaySyllabus : Form
    {
        public FrmDisplaySyllabus()
        {
            InitializeComponent();
        }

        private void FrmDisplaySyllabus_Load(object sender, EventArgs e)
        {
            LoadEntrySyllabus();
        }
        public void LoadEntrySyllabus()
        {
            Add add = new Add();
            ArrayList list = new ArrayList();
            list = add.GetSyllabus();
            lvDisplaySyllabus.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem((list[i] as Add).Course_code);

                // item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Course_title);
                item.SubItems.Add((list[i] as Add).Course_credit);

                item.SubItems.Add((list[i] as Add).Year);
                item.SubItems.Add((list[i] as Add).Semester);
               
               
                

                lvDisplaySyllabus.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvDisplaySyllabus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
