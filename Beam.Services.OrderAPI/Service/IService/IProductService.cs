using Beam.Services.OrderAPI.Models.Dto;

namespace Beam.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
