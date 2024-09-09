namespace DXApplication.Models
{
    public class cCustomizationValue
    {
        public string tValueId { get; set; } // รหัสตัวเลือกย่อย
        public string tValue { get; set; } // ค่าที่เลือกได้ (เช่น เผ็ดน้อย)
        public decimal cAdditionalPrice { get; set; } // ราคาที่เพิ่มขึ้นหากเลือกตัวเลือกนี้
    }
}