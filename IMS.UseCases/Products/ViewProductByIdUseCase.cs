using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Products
{
    public class ViewProductByIdUseCase : IViewProductByIdUseCase
    {
        private readonly IProductRepository pruductRepository;

        public ViewProductByIdUseCase(IProductRepository pruductRepository)
        {
            this.pruductRepository = pruductRepository;
        }

        public async Task<Product> ExecuteAsync(int productId)
        {
            return await pruductRepository.GetProductByIdAsync(productId);
        }
    }
}
