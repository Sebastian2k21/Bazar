using System.Security.Claims;

namespace Bazar.Services
{
    public interface IAdminManager
    {
        bool IsAdmin(ClaimsPrincipal user);
    }
}
