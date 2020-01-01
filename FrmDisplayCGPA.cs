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
    public partial class FrmDisplayCGPA : Form
    {
        public FrmDisplayCGPA()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDisplayCGPA_Load(object sender, EventArgs e)
        {
            LoadCGPA();
        }
        public void LoadCGPA()
        {
            Add add = new Add();
            ArrayList list = new ArrayList();
            list = add.GetCGPA();
            lvDisplayCGPA.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem((list[i] as Add).Roll);

                item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Session);
                item.SubItems.Add((list[i] as Add).Psession);
                item.SubItems.Add((list[i] as Add).Fcgpa);
                item.SubItems.Add((list[i] as Add).Total_credit);
                item.SubItems.Add((list[i] as Add).Remarks);

                lvDisplayCGPA.Items.Add(item);
            }
        }

    }
}
