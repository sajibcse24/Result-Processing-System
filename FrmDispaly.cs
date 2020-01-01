using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections ;
using DepartmentManagement.Services;

namespace DepartmentManagement
{
    public partial class FrmDispaly : Form
    {
        public FrmDispaly()
        {
            InitializeComponent();
        }

        private void FrmDispaly_Load(object sender, EventArgs e)
        {
            LoadEntry();
        }
        public void LoadEntry()
        {
            Add add = new Add();
            ArrayList list = new ArrayList();
            list = add.Get();
            lvDisplay.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem((list[i] as Add).Roll);
                // item.Tag = list[i] as Add;
                // lvSearch.Items.Add(item);
                item.SubItems.Add((list[i] as Add).Name);
                item.SubItems.Add((list[i] as Add).Session);
                item.SubItems.Add((list[i] as Add).Psession);
                item.SubItems.Add((list[i] as Add).Registration_no);
                item.SubItems.Add((list[i] as Add).Sex);
                
                item.SubItems.Add((list[i] as Add).Blood_group);
                item.SubItems.Add((list[i] as Add).Mobile_no);
                item.SubItems.Add((list[i] as Add).Email);
               
                lvDisplay.Items.Add(item);
            }
        }

        private void lvDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
