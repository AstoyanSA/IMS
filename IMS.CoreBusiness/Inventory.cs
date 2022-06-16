using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Введите название инвенторя!")]
        public string? InventoryName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Количество должно быть больше или равно 0")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Цена должна быть больше или равна 0")]
        public double Price { get; set; }

        public List<ProductInventory>? ProductInventories { get; set; }
    }
}