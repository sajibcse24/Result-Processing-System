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
    public partial class FrmDisplayGPA : Form
    {
        public FrmDisplayGPA()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDisplayGPA_Load(object sender, EventArgs e)
        {
            LoadGPA();
        }
        public void LoadGPA()
        {
            Add add = new Add();
            ArrayList list = new ArrayList();
            list = add.GetGPA();
            lvDisplayGPA.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem((list[i] as Add).Roll);

                // item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Session);
                item.SubItems.Add((list[i] as Add).Psession);
                item.SubItems.Add((list[i] as Add).Year);
                item.SubItems.Add((list[i] as Add).Semester);
                item.SubItems.Add((list[i] as Add).Fgpa);
                item.SubItems.Add((list[i] as Add).Gpa_history);
                item.SubItems.Add((list[i] as Add).Fcgpa);
                item.SubItems.Add((list[i] as Add).Cgpa_history);
                item.SubItems.Add((list[i] as Add).Total_credit);
               

                lvDisplayGPA.Items.Add(item);
            }
        
        
        }
    }
}
