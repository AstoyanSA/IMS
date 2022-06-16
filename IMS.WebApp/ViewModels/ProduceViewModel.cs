using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels
{
    public class ProduceViewModel
    {
        [Required(ErrorMessage = "Заполните название продукта")]
        public string ProductionNumber { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Выберите инвентарь")]
        public string ProductName { get; set; }

        [Required]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Количество должно быть больше 0")]
        public int QuantityToProduce { get; set; }
        public double ProductPrice { get; set; }
    }
}
