using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ang.Models;

namespace ang.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    { 
        private readonly IConfiguration _config;
        public readonly UserContext _context;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IConfiguration config, UserContext context)
        {
            _config = config;
            _context = context;
        }

        [HttpPost("LoginUser")]
        public IActionResult Login(string username, string password)
        {
            var userAvailable = _context.SystemUser.Where(u => u.user_name == username && u.password == password).FirstOrDefault();
            if (userAvailable != null)
            {
                return Ok("success");

            }
            return Ok("Failure");
        }
       
    }
}
