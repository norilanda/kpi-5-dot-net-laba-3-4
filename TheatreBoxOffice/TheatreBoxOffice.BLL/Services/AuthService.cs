using Microsoft.AspNetCore.Identity;
using TheatreBoxOffice.BLL.Exceptions;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common;
using TheatreBoxOffice.Common.DTO.Token;
using TheatreBoxOffice.Common.DTO.User;

namespace TheatreBoxOffice.BLL.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ITokenService _tokenService;

    public AuthService(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ITokenService tokenService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _tokenService = tokenService;
    }
    public async Task<TokenDto> LoginAsync(LoginDto userDto)
    {
        var user = await _userManager.FindByEmailAsync(userDto.Email);
        if (user == null || !await _userManager.CheckPasswordAsync(user, userDto.Password))
            throw ResponseException.BadRequest("Invalid Credentials");

        var userRoles = await _userManager.GetRolesAsync(user);

        var token = _tokenService.GenerateAccessToken(user.Id, userRoles);
        return new TokenDto() { AccessToken = token };
    }

    public async Task<TokenDto> RegisterAsync(RegisterDto userDto)
    {
        var userExists = await _userManager.FindByEmailAsync(userDto.Email);
        if (userExists != null)
            throw ResponseException.BadRequest("Invalid Credentials");

        var user = await CreateNewUserAsync(userDto.Email, userDto.Password);

        var token = _tokenService.GenerateAccessToken(user.Id, new List<string>());
        return new TokenDto() { AccessToken = token };
    }

    public async Task<TokenDto> RegisterManagerAsync(RegisterDto userDto)
    {
        return await CreateOrChangeUserRoles(userDto, new List<string>() { UserRoles.Manager });
    }

    private async Task<TokenDto> CreateOrChangeUserRoles(RegisterDto userDto, List<string> roles)
    {
        var user = await CreateOrGetUserAsync(userDto);

        foreach (var role in roles)
        {
            if (!await _roleManager.RoleExistsAsync(role))
                await _roleManager.CreateAsync(new IdentityRole(role));
        }

        foreach (var role in roles)
        {
            await _userManager.AddToRoleAsync(user, role);
        }

        var token = _tokenService.GenerateAccessToken(user.Id, roles);
        return new TokenDto() { AccessToken = token };
    }

    private async Task<IdentityUser> CreateOrGetUserAsync(RegisterDto userDto)
    {
        var user = await _userManager.FindByEmailAsync(userDto.Email);

        if (user != null && !await _userManager.CheckPasswordAsync(user, userDto.Password))
            throw ResponseException.BadRequest("Invalid Credentials");

        else if (user == null)
            user = await CreateNewUserAsync(userDto.Email, userDto.Password);

        return user;
    }

    private async Task<IdentityUser> CreateNewUserAsync(string email, string password)
    {
        IdentityUser user = new()
        {
            Email = email,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = email,
        };

        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
            throw ResponseException.InternalServerError();

        return user;
    }

    //public Task LogoutAsync(string refreshTokenDto)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<TokenDto> RefreshAsync(string refreshTokenDto)
    //{
    //    throw new NotImplementedException();
    //}
}
