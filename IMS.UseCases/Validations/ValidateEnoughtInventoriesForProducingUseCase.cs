using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Validations
{
    public class ValidateEnoughtInventoriesForProducingUseCase : IValidateEnoughtInventoriesForProducingUseCase
    {
        private readonly IProductRepository productrepository;

        public ValidateEnoughtInventoriesForProducingUseCase(IProductRepository productrepository)
        {
            this.productrepository = productrepository;
        }
        public async Task<bool> ExecuteAsync(Product product, int quantity)
        {
            var prod = await productrepository.GetProductByIdAsync(product.ProductId);

            foreach (var pi in prod.ProductInventories)
            {
                if (pi.InventoryQuantity * quantity > pi.Inventory.Quantity) return false;
            }
            return true;
        }
    }
}
