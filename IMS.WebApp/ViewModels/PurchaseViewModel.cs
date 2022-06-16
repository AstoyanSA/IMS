using IMS.CoreBusiness;
using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels
{
    public class PurchaseViewModel
    {
        [Required(ErrorMessage = "Заполните название заказа на покупку")]
        public string PurchaseOrder { get; set; }

        [Required]
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Выберите инвентарь")]
        public string InventoryName { get; set; }

        [Required]
        [Range(minimum:1, maximum:int.MaxValue, ErrorMessage = "Количество должно быть больше 0")]
        public int QuantityToPurchase { get; set; }
        public double InventoryPrice { get; set; }
    }
}
