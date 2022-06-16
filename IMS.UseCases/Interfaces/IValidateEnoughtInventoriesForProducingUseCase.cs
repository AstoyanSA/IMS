using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IValidateEnoughtInventoriesForProducingUseCase
    {
        Task<bool> ExecuteAsync(Product product, int quantity);
    }
}