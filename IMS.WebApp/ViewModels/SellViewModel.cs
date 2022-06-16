using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels
{
    public class SellViewModel
    {
        [Required(ErrorMessage = "Заполните название продукта")]
        public string SalesOrderNumber { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Выберите инвентарь")]
        public string ProductName { get; set; }

        [Required]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Количество должно быть больше 0")]
        public int QuantityToSell { get; set; }
        [Required]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Стоимость должна быть больше 0")]
        public double ProductPrice { get; set; }
    }
}
