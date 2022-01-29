using CMISDataEngin.Common;
using CMISUIEngin.Forms;
using CMISUIEngin.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODCC_WinApplication.CMISElectrical.Main
{
    public partial class MainForm : CMISRibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.ProjectId = 1;
            this.ProjectName = "ARUP-1071";
            this.SysUserId = 1119;
            this.FullName = "Ehsan Setode";
            this.LastLoginDate = DateTime.Now;

            this.CompanyDataSource = FillCompaniesCombo();
            this.CompanyDisplayMember = "FullName";
            this.CompanyValueMember = "Id";
        }

        private DataTable FillCompaniesCombo()
        {
            var data = CMDAL.SharedDAL.GetCompaniesCombo("CM.FetchCompaniesCombo", this.ProjectId, this.SysUserId, $"{Bundle.SCHEMA}.COMPANY");
            return data;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIManager.OpenForm<Other.HomeForm>(this);
        }
    }
}
