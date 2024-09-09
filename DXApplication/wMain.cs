using DXApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication
{
    public partial class wMain : DevExpress.XtraEditors.XtraForm
    {
        public wMain()
        {
            InitializeComponent();
            W_SETxDesign();
            W_GETxDATA();
        }

        private void W_GETxDATA()
        {
            try
            {
                cMenuItem menuItem = new cMenuItem
                {
                     
                    aoIngredients = new List<cIngredient>
                    {
        new cIngredient { tIngredientId = "Fish001", tName = "ปลาช่อน", cQuantity = 1, tUnit = "ตัว" },
        new cIngredient { tIngredientId = "Garlic001", tName = "กระเทียม", cQuantity = 50, tUnit = "กรัม" },
        new cIngredient { tIngredientId = "Chili001", tName = "พริก", cQuantity = 20, tUnit = "กรัม" },
        new cIngredient { tIngredientId = "Oil001", tName = "น้ำมัน", cQuantity = 100, tUnit = "มิลลิลิตร" }
    },
                    aoCustomizationOptions = new List<cCustomizationOption>
    {
        new cCustomizationOption
        {
            tOptionId = "SpiceLevel01",
            tName = "ระดับความเผ็ด",
            aoValues = new List<cCustomizationValue>
            {
                new cCustomizationValue { tValueId = "Mild", tValue = "เผ็ดน้อย", cAdditionalPrice = 0 },
                new cCustomizationValue { tValueId = "Medium", tValue = "เผ็ดกลาง", cAdditionalPrice = 0 },
                new cCustomizationValue { tValueId = "Spicy", tValue = "เผ็ดมาก", cAdditionalPrice = 0 }
            }
        }
    },
                    bIsAvailable = true
                };

            }
            catch (Exception oEx) { }
            finally
            {

            }
        }

        private void W_SETxDesign()
        {
        }
    }
}
