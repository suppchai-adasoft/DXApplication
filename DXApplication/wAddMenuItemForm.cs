using DevExpress.XtraEditors;
using DXApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication
{
    public partial class wAddMenuItemForm : DevExpress.XtraEditors.XtraForm
    {
        public cMenuItem NewMenuItem { get; private set; }

        public wAddMenuItemForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // สร้างเมนูใหม่จากข้อมูลที่ผู้ใช้กรอก
            NewMenuItem = new cMenuItem
            {
                tMenuItemId = otbMenuItemId.Text,
                tName = otbName.Text,
                tDescription = otbDescription.Text,
                cPrice = decimal.Parse(otbPrice.Text),
                bIsAvailable = chkIsAvailable.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}