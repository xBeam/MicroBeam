using Beam.Services.EmailAPI.Message;
using Beam.Services.EmailAPI.Models.Dto;

namespace Beam.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
