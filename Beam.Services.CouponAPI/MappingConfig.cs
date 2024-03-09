using AutoMapper;
using Beam.Services.CouponAPI.Models;
using Beam.Services.CouponAPI.Models.Dto;

namespace Beam.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto> ();

            });

            return mappingConfig;
        }
    }
}
