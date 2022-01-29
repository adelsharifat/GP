using CMISDataEngin.Common;
using CMISUtilities;
using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODCC_WinApplication
{
    public partial class WInAPP : Form
    {
        public WInAPP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new JobReport.Main.MainForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new CMISAclManager.Main.MainForm()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new CMISElectrical.Main.MainForm()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginInfo.Id = UserVirtual.UserVM.Id;
            LoginInfo.JobTitle = UserVirtual.UserVM.JobTitle;
            LoginInfo.FirstName = UserVirtual.UserVM.FirstName;
            LoginInfo.LastName = UserVirtual.UserVM.LastName;

            (new CMISGatePass.Main.MainForm()).Show();
        }

        private void FillUserCombo()
        {
            try
            {
                var data = CMDAL.UserDAL.FetchUsers();
                lookUpEdit1.Properties.DataSource = data;
                lookUpEdit1.Properties.DisplayMember = "UserName";
                lookUpEdit1.Properties.ValueMember = "Id";
                lookUpEdit1.Properties.KeyMember = "Id";               
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void WInAPP_Load(object sender, EventArgs e)
        {
            FillUserCombo();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var userData = CMDAL.UserDAL.GetUserById("CM.FetchUserById", Convert.ToInt16(lookUpEdit1.EditValue));

                if (userData != null && userData.Rows.Count > 0)
                {
                    UserVirtual.UserVM.Id = Convert.ToInt32(userData.Rows[0]["Id"]);
                    UserVirtual.UserVM.JobTitle = Convert.ToString(userData.Rows[0]["JobTitle"]);
                    UserVirtual.UserVM.FirstName = Convert.ToString(userData.Rows[0]["FirstName"]);
                    UserVirtual.UserVM.LastName = Convert.ToString(userData.Rows[0]["LastName"]);
                }

            }
            catch (Exception ex)
            {

                ex.ShowMessage();
            }
        }
    }
}
