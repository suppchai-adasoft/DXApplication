using System.Collections.Generic;

namespace DXApplication.Models
{
    public class cCustomizationOption
    {
        public string tOptionId { get; set; } // รหัสตัวเลือกการปรับแต่ง
        public string tName { get; set; } // ชื่อตัวเลือกการปรับแต่ง (เช่น เลือกระดับความเผ็ด)
        public List<cCustomizationValue> aoValues { get; set; } // ตัวเลือกที่สามารถเลือกได้ เช่น เผ็ดน้อย, เผ็ดมาก
    }
}