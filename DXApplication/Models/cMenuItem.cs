using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Models
{
    public class cMenuItem
    {
        public string tMenuItemId { get; set; } // รหัสเมนูอาหาร
        public string tName { get; set; } // ชื่ออาหาร
        public string tDescription { get; set; } // คำอธิบายอาหาร
        public decimal cPrice { get; set; } // ราคาต่อหน่วย
        public List<cIngredient> aoIngredients { get; set; } // รายการวัตถุดิบที่ใช้ในเมนู
        public List<cCustomizationOption> aoCustomizationOptions { get; set; } // ตัวเลือกการปรับแต่งเมนู
        public bool bIsAvailable { get; set; } // สถานะพร้อมให้บริการ
    }
}
