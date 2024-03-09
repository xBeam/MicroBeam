using Beam.Services.AuthAPI.Models;

namespace Beam.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator 
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
