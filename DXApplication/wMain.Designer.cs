namespace DXApplication
{
    partial class wMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wMainForm));
            this.ogbData = new DevExpress.XtraGrid.GridControl();
            this.ogdDataList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.otbColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColMenuItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ocmAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ogbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogbData
            // 
            this.ogbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ogbData.Location = new System.Drawing.Point(2, 2);
            this.ogbData.MainView = this.ogdDataList;
            this.ogbData.Name = "ogbData";
            this.ogbData.Size = new System.Drawing.Size(628, 314);
            this.ogbData.TabIndex = 0;
            this.ogbData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ogdDataList});
            // 
            // ogdDataList
            // 
            this.ogdDataList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.otbColName,
            this.otbColDescription,
            this.otbColPrice,
            this.otbColMenuItemId});
            this.ogdDataList.GridControl = this.ogbData;
            this.ogdDataList.Name = "ogdDataList";
            // 
            // otbColName
            // 
            this.otbColName.Caption = "ชื่ออาหาร";
            this.otbColName.FieldName = "tName";
            this.otbColName.Name = "otbColName";
            this.otbColName.Visible = true;
            this.otbColName.VisibleIndex = 0;
            // 
            // otbColDescription
            // 
            this.otbColDescription.Caption = "คำอธิบายอาหาร";
            this.otbColDescription.FieldName = "tDescription";
            this.otbColDescription.Name = "otbColDescription";
            this.otbColDescription.Visible = true;
            this.otbColDescription.VisibleIndex = 1;
            // 
            // otbColPrice
            // 
            this.otbColPrice.Caption = "ราคาต่อหน่วย";
            this.otbColPrice.FieldName = "cPrice";
            this.otbColPrice.Name = "otbColPrice";
            this.otbColPrice.Visible = true;
            this.otbColPrice.VisibleIndex = 2;
            // 
            // otbColMenuItemId
            // 
            this.otbColMenuItemId.Caption = "รหัสเมนูอาหาร";
            this.otbColMenuItemId.FieldName = "tMenuItemId";
            this.otbColMenuItemId.Name = "otbColMenuItemId";
            // 
            // ocmAdd
            // 
            this.ocmAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ocmAdd.ImageOptions.SvgImage")));
            this.ocmAdd.Location = new System.Drawing.Point(477, 5);
            this.ocmAdd.Name = "ocmAdd";
            this.ocmAdd.Size = new System.Drawing.Size(150, 45);
            this.ocmAdd.TabIndex = 1;
            this.ocmAdd.Text = "เพิ่มข้อมูล";
            this.ocmAdd.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ocmAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(632, 56);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ogbData);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(632, 318);
            this.panelControl2.TabIndex = 3;
            // 
            // wMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 374);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "wMainForm";
            this.Text = "DevExpress Workshop";
            ((System.ComponentModel.ISupportInitialize)(this.ogbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ogbData;
        private DevExpress.XtraGrid.Views.Grid.GridView ogdDataList;
        private DevExpress.XtraEditors.SimpleButton ocmAdd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn otbColName;
        private DevExpress.XtraGrid.Columns.GridColumn otbColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn otbColPrice;
        private DevExpress.XtraGrid.Columns.GridColumn otbColMenuItemId;
    }
}

