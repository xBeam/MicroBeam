using AutoMapper;
using Beam.Services.ShoppingCartAPI.Models;
using Beam.Services.ShoppingCartAPI.Models.Dto;

namespace Beam.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
