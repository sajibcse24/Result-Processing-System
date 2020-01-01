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
    public partial class FrmSearchTeachers : Form
    {
        public FrmSearchTeachers()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {

                MessageBox.Show("Please enter Name !");
                txtName.Focus();
                return;


            }


            Add add = new Add();
            ArrayList list = new ArrayList();
            string name = Convert.ToString(txtName.Text);

          

           // list = add.searchteacher(name);


             lvSearchTeachers.Items.Clear();

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
                  lvSearchTeachers.Items.Add(item);


            }

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            lvSearchTeachers.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
