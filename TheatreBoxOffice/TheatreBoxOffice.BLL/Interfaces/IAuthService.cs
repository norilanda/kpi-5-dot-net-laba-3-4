using TheatreBoxOffice.Common.DTO.Token;
using TheatreBoxOffice.Common.DTO.User;

namespace TheatreBoxOffice.BLL.Interfaces;

public interface IAuthService
{
    public Task<TokenDto> LoginAsync(LoginDto userDto);
    public Task<TokenDto> RegisterAsync(RegisterDto userDto);
    public Task<TokenDto> RegisterManagerAsync(RegisterDto userDto);
    //public Task LogoutAsync(string refreshTokenDto);
    //public Task<TokenDto> RefreshAsync(string refreshTokenDto);
}
