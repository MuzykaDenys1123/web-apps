using Microsoft.AspNetCore.Identity;

namespace Lab4.BLL.Services.Abstractions;

public interface IJwtGenerationService
{
    Task<string> GenerateToken(IdentityUser user);
}
