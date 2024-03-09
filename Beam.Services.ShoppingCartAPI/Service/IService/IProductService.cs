using Beam.Services.ShoppingCartAPI.Models.Dto;

namespace Beam.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
