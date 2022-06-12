using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishTank.API.Controllers
{
    [Route("api/hc")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Jest Super!";
        }
    }
}
