using MovieCatalogueApi.Models;

namespace MovieCatalogueApi.Services
{
    public interface ITokenService
    {
        ConnectedUser Authenticate(string email, string password);
    }
}