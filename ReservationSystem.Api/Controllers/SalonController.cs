using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Salons.Commands.CreateSalon;
using ReservationSystem.Application.Salons.Commands.DeleteSalon;
using ReservationSystem.Application.Salons.Commands.UpdateSalon;
using ReservationSystem.Application.Salons.Queries.GetSalonDetail;
using ReservationSystem.Application.Salons.Queries.GetSalons;
using ReservationSystem.Persistance;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/salons")]
    public class SalonController : BaseController
    {
        private readonly ReservationDbContext _context;

        public SalonController(ReservationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalonDetailVm>> GetDetails(Guid id)
        {
            var vm = await Mediator.Send(new GetSalonDetailQuery() { SalonId = id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<SalonsVm>> GetSalonsList()
        {
            var salons = await _context.Salons.AsNoTracking().ToListAsync();
            return Ok(salons);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateSalon(CreateSalonCommand command)
        {
            var salonId = await Mediator.Send(command);
            return Ok(salonId);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSalon(Guid id, [FromBody] UpdateSalonCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSalon(Guid id)
        {
            await Mediator.Send(new DeleteSalonCommand { SalonId = id });
            return NoContent();
        }
    }
}
