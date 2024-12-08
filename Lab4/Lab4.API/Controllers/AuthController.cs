using Lab4.BLL.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IJwtGenerationService _jwtService;

    public AuthController(UserManager<IdentityUser> userManager, IJwtGenerationService jwtService)
    {
        _userManager = userManager;
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginDTO loginDTO)
    {
        var user = await _userManager.FindByEmailAsync(loginDTO.Email);

        if (user != null && await _userManager.CheckPasswordAsync(user, loginDTO.Password))
        {
            var token = await _jwtService.GenerateToken(user);
            return Ok(new { Token = token });
        }
        return Unauthorized();
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] LoginDTO registerDTO)
    {
        var user = await _userManager.FindByEmailAsync(registerDTO.Email);

        if (user == null)
        {
            user = new IdentityUser(registerDTO.Email)
            {
                Email = registerDTO.Email
            };

            var result = await _userManager.CreateAsync(user, registerDTO.Password);
        }
        return Ok();
    }
}