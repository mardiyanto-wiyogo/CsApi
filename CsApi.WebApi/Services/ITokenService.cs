using CsApi.WebApi.Models;

namespace CsApi.WebApi.Services;

public interface ITokenService
{
    string GenerateAccessToken(User user);
}