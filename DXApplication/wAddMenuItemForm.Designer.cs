namespace DXApplication
{
    partial class wAddMenuItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wAddMenuItemForm));
            this.otbMenuItemId = new DevExpress.XtraEditors.TextEdit();
            this.otbName = new DevExpress.XtraEditors.TextEdit();
            this.otbPrice = new DevExpress.XtraEditors.TextEdit();
            this.chkIsAvailable = new DevExpress.XtraEditors.CheckEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.otbDescription = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.otbMenuItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAvailable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // otbMenuItemId
            // 
            this.otbMenuItemId.Location = new System.Drawing.Point(13, 19);
            this.otbMenuItemId.Name = "otbMenuItemId";
            this.otbMenuItemId.Properties.NullText = "รหัสเมนู";
            this.otbMenuItemId.Properties.NullValuePrompt = "รหัสเมนู";
            this.otbMenuItemId.Size = new System.Drawing.Size(363, 28);
            this.otbMenuItemId.TabIndex = 0;
            // 
            // otbName
            // 
            this.otbName.Location = new System.Drawing.Point(12, 53);
            this.otbName.Name = "otbName";
            this.otbName.Properties.NullText = "ชื่อเมนู";
            this.otbName.Properties.NullValuePrompt = "ชื่อเมนู";
            this.otbName.Size = new System.Drawing.Size(364, 28);
            this.otbName.TabIndex = 1;
            // 
            // otbPrice
            // 
            this.otbPrice.Location = new System.Drawing.Point(13, 121);
            this.otbPrice.Name = "otbPrice";
            this.otbPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.otbPrice.Properties.NullText = "ราคา";
            this.otbPrice.Properties.NullValuePrompt = "ราคา";
            this.otbPrice.Size = new System.Drawing.Size(363, 28);
            this.otbPrice.TabIndex = 3;
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.Location = new System.Drawing.Point(13, 155);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Properties.Caption = "checkEdit1";
            this.chkIsAvailable.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.chkIsAvailable.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkIsAvailable.Properties.NullText = "Active";
            this.chkIsAvailable.Size = new System.Drawing.Size(75, 44);
            this.chkIsAvailable.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(70, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 45);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "บันทึก";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(226, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // otbDescription
            // 
            this.otbDescription.Location = new System.Drawing.Point(13, 87);
            this.otbDescription.Name = "otbDescription";
            this.otbDescription.Properties.NullText = "คำอธิบาย";
            this.otbDescription.Properties.NullValuePrompt = "คำอธิบาย";
            this.otbDescription.Size = new System.Drawing.Size(363, 28);
            this.otbDescription.TabIndex = 2;
            // 
            // wAddMenuItemForm
            // 
            this.ClientSize = new System.Drawing.Size(388, 259);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.otbPrice);
            this.Controls.Add(this.otbName);
            this.Controls.Add(this.otbMenuItemId);
            this.Controls.Add(this.otbDescription);
            this.MinimizeBox = false;
            this.Name = "wAddMenuItemForm";
            this.Text = "เพิ่มเมนูใหม่";
            ((System.ComponentModel.ISupportInitialize)(this.otbMenuItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAvailable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit otbMenuItemId;
        private DevExpress.XtraEditors.TextEdit otbName;
        private DevExpress.XtraEditors.TextEdit otbPrice;
        private DevExpress.XtraEditors.CheckEdit chkIsAvailable;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit otbDescription;
    }
}