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
    public partial class FrmSearchTeachersByDesignation : Form
    {
        public FrmSearchTeachersByDesignation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmDesignation.Text == "")
            {

                MessageBox.Show("Please enter Name !");
                cmDesignation.Focus();
                return;


            }


            Add add = new Add();
            ArrayList list = new ArrayList();
            string designation = Convert.ToString(cmDesignation.Text);



          //  list = add.searchteacherbydesignation(designation);


            lvSearchTeachersByDesignation.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {

                ListViewItem item = new ListViewItem((list[i] as Add).Name);

                // item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Designation);
                item.SubItems.Add((list[i] as Add).Dateofjoin);


                item.SubItems.Add((list[i] as Add).Blood_group);
                item.SubItems.Add((list[i] as Add).Mobile_no);
                item.SubItems.Add((list[i] as Add).Email);
                lvSearchTeachersByDesignation.Items.Add(item);


            }

        }
    }
}
