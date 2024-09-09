namespace DXApplication
{
    partial class wMain
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
            this.ogbData = new DevExpress.XtraGrid.GridControl();
            this.ogdDataList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.otbColMenuItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // ogbData
            // 
            this.ogbData.Location = new System.Drawing.Point(13, 13);
            this.ogbData.MainView = this.ogdDataList;
            this.ogbData.Name = "ogbData";
            this.ogbData.Size = new System.Drawing.Size(607, 253);
            this.ogbData.TabIndex = 0;
            this.ogbData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ogdDataList});
            // 
            // ogdDataList
            // 
            this.ogdDataList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.otbColMenuItemId,
            this.otbColName,
            this.otbColDescription,
            this.otbColPrice});
            this.ogdDataList.GridControl = this.ogbData;
            this.ogdDataList.Name = "ogdDataList";
            // 
            // otbColMenuItemId
            // 
            this.otbColMenuItemId.Caption = "tMenuItemId";
            this.otbColMenuItemId.FieldName = "tMenuItemId";
            this.otbColMenuItemId.Name = "otbColMenuItemId";
            this.otbColMenuItemId.Visible = true;
            this.otbColMenuItemId.VisibleIndex = 0;
            // 
            // otbColName
            // 
            this.otbColName.Caption = "tName";
            this.otbColName.FieldName = "tName";
            this.otbColName.Name = "otbColName";
            this.otbColName.Visible = true;
            this.otbColName.VisibleIndex = 1;
            // 
            // otbColDescription
            // 
            this.otbColDescription.Caption = "tDescription";
            this.otbColDescription.FieldName = "tDescription";
            this.otbColDescription.Name = "otbColDescription";
            this.otbColDescription.Visible = true;
            this.otbColDescription.VisibleIndex = 2;
            // 
            // otbColPrice
            // 
            this.otbColPrice.Caption = "cPrice";
            this.otbColPrice.FieldName = "cPrice";
            this.otbColPrice.Name = "otbColPrice";
            this.otbColPrice.Visible = true;
            this.otbColPrice.VisibleIndex = 3;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.ogbData);
            this.Name = "wMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ogbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ogbData;
        private DevExpress.XtraGrid.Views.Grid.GridView ogdDataList;
        private DevExpress.XtraGrid.Columns.GridColumn otbColMenuItemId;
        private DevExpress.XtraGrid.Columns.GridColumn otbColName;
        private DevExpress.XtraGrid.Columns.GridColumn otbColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn otbColPrice;
    }
}

