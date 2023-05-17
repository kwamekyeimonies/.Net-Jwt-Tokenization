using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserAppAuth.System.Database;

namespace UserAppAuth.System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        protected readonly ApiDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationController(ApiDbContext context)
        {
            _context = context;
        }
    }
}