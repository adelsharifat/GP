using CMISUIEngin.Forms;
using ODCC_WinApplication.CMISAclManager.Infrastructure.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODCC_WinApplication.CMISElectrical.Other
{
    public partial class HomeForm : CMISForm
    {
        public HomeForm()
        {
            InitializeComponent();
            cmisGridTools1.AddDefaultMenu();
        }

        private void Trash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Word");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
           
        }


        private void cmisGridTools1_OnRefreshStat(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh Data And Reset Column Worked");
            
        }

        private void cmisGridTools1_OnRemoveRow(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Row Worked");
        }

        private void HomeForm_Load_1(object sender, EventArgs e)
        {
            cmisGridTools1.Grid = xGridControl1;
            xGridControl1.DataSource = CMISACLDAL.DAL.GetUserList();
        }
    }
}
