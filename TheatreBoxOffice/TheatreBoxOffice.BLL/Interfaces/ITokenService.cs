namespace TheatreBoxOffice.BLL.Interfaces;

public interface ITokenService
{
    public string GenerateAccessToken();
    public string GenerateRefreshToken();
}
