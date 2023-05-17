using Microsoft.AspNetCore.Mvc;
using UserAppAuth.System.Database;

namespace UserAppAuth.System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TeamController(ApiDbContext context)
        {
            _context = context;
        }
    }
}