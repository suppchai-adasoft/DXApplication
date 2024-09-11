using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication
{
    public partial class wMainForm : Form
    {
        // ตัวอย่างข้อมูลที่นำมาแสดงใน GridControl
        private List<cMenuItem> dalMenuItems = new List<cMenuItem>
    {
        new cMenuItem
        {
            tMenuItemId = "M001",
            tName = "Pad Thai",
            tDescription = "Delicious Pad Thai with prawns",
            cPrice = 85.00m,
            aoIngredients = new List<cIngredient>
            {
                new cIngredient { tIngredientId = "I001", tName = "Rice Noodles", cQuantity = 100, tUnit = "grams" }
            },
            aoCustomizationOptions = new List<cCustomizationOption>
            {
                new cCustomizationOption
                {
                    tOptionId = "O001", tName = "Spice Level", aoValues = new List<cCustomizationValue>
                    {
                        new cCustomizationValue { tValueId = "V001", tValue = "Mild", cAdditionalPrice = 0 },
                        new cCustomizationValue { tValueId = "V002", tValue = "Hot", cAdditionalPrice = 5 }
                    }
                }
            },
            bIsAvailable = true
        },
        new cMenuItem
        {
            tMenuItemId = "M002",
            tName = "Green Curry",
            tDescription = "Green curry with chicken",
            cPrice = 90.00m,
            aoIngredients = new List<cIngredient>
            {
                new cIngredient { tIngredientId = "I002", tName = "Coconut Milk", cQuantity = 200, tUnit = "ml" }
            },
            aoCustomizationOptions = new List<cCustomizationOption>
            {
                new cCustomizationOption
                {
                    tOptionId = "O002", tName = "Rice", aoValues = new List<cCustomizationValue>
                    {
                        new cCustomizationValue { tValueId = "V003", tValue = "With Rice", cAdditionalPrice = 10 },
                        new cCustomizationValue { tValueId = "V004", tValue = "Without Rice", cAdditionalPrice = 0 }
                    }
                }
            },
            bIsAvailable = true
        }
    };

        public wMainForm()
        {
            InitializeComponent();

            // 1. Set Data ไปยัง Grid
            ogbData.DataSource = dalMenuItems;

            // 2. กำหนด Caption ของ Grid
            ogdDataList.Columns["tName"].Caption = "ชื่อเมนู";
            ogdDataList.Columns["tDescription"].Caption = "คำอธิบาย";
            ogdDataList.Columns["cPrice"].Caption = "ราคา";

            // 3. Set สีตาม Row
            ogdDataList.RowStyle += olayDataList_RowStyle;

            // 4. Merge Rows/Columns
            ogdDataList.OptionsView.AllowCellMerge = true;
            ogdDataList.CellMerge += olayDataList_CellMerge;


            // 5. แสดงรูปใน DataGrid
            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit
            {
                SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze // ปรับขนาดให้พอดีกับเซลล์
            };
            ogbData.RepositoryItems.Add(pictureEdit);

            // เพิ่มคอลัมน์ใหม่สำหรับแสดงรูปภาพ
            DevExpress.XtraGrid.Columns.GridColumn imageColumn = new DevExpress.XtraGrid.Columns.GridColumn()
            {
                Caption = "รูปภาพ",
                UnboundType = DevExpress.Data.UnboundColumnType.Object,
                FieldName = "ImageColumn",
                Visible = true,
                OptionsColumn = { AllowSize = true } // ให้คอลัมน์สามารถขยายขนาดได้
            };

            // กำหนดให้คอลัมน์ใช้ PictureEdit
            imageColumn.ColumnEdit = pictureEdit;

            // เพิ่มคอลัมน์ลงใน GridView
            ogdDataList.Columns.Add(imageColumn);

            // ปรับขนาดความสูงของแถว
            ogdDataList.RowHeight = 100; // ตั้งค่าความสูงแถวที่ใหญ่ขึ้น

            // กำหนด CustomUnboundColumnData สำหรับการแสดงรูปภาพ
            ogdDataList.CustomUnboundColumnData += olayDataList_CustomUnboundColumnData;
        }

        // ฟังก์ชันการ Set สีตาม Row
        private void olayDataList_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView olayView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string tMenuItemId = olayView.GetRowCellValue(e.RowHandle, olayView.Columns["tMenuItemId"]).ToString();
                if (tMenuItemId == "M001")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
            }
        }

        // ฟังก์ชัน Merge Row หรือ Column
        private void olayDataList_CellMerge(object sender, CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "tDescription")
            {
                e.Merge = true; // ให้ Merge คอลัมน์ tDescription
                e.Handled = true;
            }
        }

        // ฟังก์ชันการแสดงรูปใน DataGrid
        private void olayDataList_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "ImageColumn" && e.IsGetData)
            {
                // กำหนดพาธของโฟลเดอร์ที่เก็บไฟล์รูป
                string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AdaImage");
                // ใส่รูปตามแต่ละเมนู (ตัวอย่างการใส่รูปจากไฟล์)
                if (e.ListSourceRowIndex == 0) e.Value = Image.FromFile(Path.Combine(imageFolderPath, "padthai.jpg"));
                if (e.ListSourceRowIndex == 1) e.Value = Image.FromFile(Path.Combine(imageFolderPath, "greencurry.jpg"));
            }
        }

        // ฟังก์ชันการ Get Data จาก Grid
        private void W_GETDataFromGrid()
        {
            int[] daSelectedRows = ogdDataList.GetSelectedRows();
            foreach (int dRowHandle in daSelectedRows)
            {
                var dMenuItem = (cMenuItem)ogdDataList.GetRow(dRowHandle);
                MessageBox.Show($"ชื่อเมนู: {dMenuItem.tName}, ราคา: {dMenuItem.cPrice}");
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            using (wAddMenuItemForm addMenuItemForm = new wAddMenuItemForm())
            {
                if (addMenuItemForm.ShowDialog() == DialogResult.OK)
                {
                    // เพิ่มเมนูใหม่ที่ผู้ใช้กรอกในฟอร์ม
                    dalMenuItems.Add(addMenuItemForm.NewMenuItem);

                    // รีเฟรช GridControl เพื่อแสดงข้อมูลใหม่
                    ogbData.RefreshDataSource();
                }
            }
        }

    }
}
