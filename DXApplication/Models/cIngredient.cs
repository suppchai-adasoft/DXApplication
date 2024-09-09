namespace DXApplication.Models
{
    public class cIngredient
    {
        public string tIngredientId { get; set; } // รหัสวัตถุดิบ
        public string tName { get; set; } // ชื่อวัตถุดิบ
        public decimal cQuantity { get; set; } // จำนวนที่ใช้ในแต่ละเมนู
        public string tUnit { get; set; } // หน่วยวัด (เช่น กรัม, ช้อนโต๊ะ)
    }
}