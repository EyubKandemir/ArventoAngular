using ang.Models;
using Microsoft.AspNetCore.Mvc;

namespace ang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardDataContext _context;

        //public DashboardController(DashboardDataContext context)
        //{
        //    _context = context;
        //}

        public DashboardController()
        {

        }

        [HttpGet("GetTotalNumBooks")]
        public  ActionResult GetTotalNumBooks()
        {
            
            return Ok(4);
        }
    }
}
