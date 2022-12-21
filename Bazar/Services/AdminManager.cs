using Bazar.Data;
using Bazar.Data.Models;
using System.Security.Claims;

namespace Bazar.Services
{
    public class AdminManager : IAdminManager
    {
        private readonly DataContext context;

        public AdminManager(DataContext context)
        {
            this.context = context;
        }
        
        public bool IsAdmin(ClaimsPrincipal user)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            var adminRole = context.Roles.FirstOrDefault(x => x.Name == "Admin");
            if(adminRole == null)
            {
                return false;
            }
            return context.UserRoles.Any(x => x.UserId == userId && x.RoleId == adminRole.Id);
        }
    }
}
