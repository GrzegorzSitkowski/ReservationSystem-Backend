using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/hc")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
