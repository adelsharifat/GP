namespace ODCC_WinApplication.CMISElectrical.Other
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmisGridTools1 = new CMISUIEngin.UserControls.CMISGridTools();
            this.xGridControl1 = new CMISUIEngin.UserControls.XGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.CboCompanyBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboCompanyBase
            // 
            this.CboCompanyBase.Location = new System.Drawing.Point(754, 5);
            this.CboCompanyBase.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCompanyBase.Properties.Appearance.Options.UseFont = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmisGridTools1);
            this.panelControl1.Location = new System.Drawing.Point(179, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(818, 31);
            this.panelControl1.TabIndex = 4;
            // 
            // cmisGridTools1
            // 
            this.cmisGridTools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmisGridTools1.Grid = null;
            this.cmisGridTools1.Location = new System.Drawing.Point(2, 2);
            this.cmisGridTools1.Name = "cmisGridTools1";
            this.cmisGridTools1.Size = new System.Drawing.Size(814, 27);
            this.cmisGridTools1.TabIndex = 0;
            this.cmisGridTools1.Text = "cmisGridTools1";
            this.cmisGridTools1.OnRefreshStat += new System.EventHandler(this.cmisGridTools1_OnRefreshStat);
            this.cmisGridTools1.OnRemoveRow += new System.EventHandler(this.cmisGridTools1_OnRemoveRow);
            // 
            // xGridControl1
            // 
            this.xGridControl1.EnableCheckBoxMultiSelection = false;
            this.xGridControl1.LayoutName = null;
            this.xGridControl1.Location = new System.Drawing.Point(179, 115);
            this.xGridControl1.MainView = this.gridView1;
            this.xGridControl1.Name = "xGridControl1";
            this.xGridControl1.Size = new System.Drawing.Size(818, 463);
            this.xGridControl1.TabIndex = 1;
            this.xGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.xGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xGridControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load_1);
            this.Controls.SetChildIndex(this.xGridControl1, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CboCompanyBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private CMISUIEngin.UserControls.CMISGridTools cmisGridTools1;
        private CMISUIEngin.UserControls.XGridControl xGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}