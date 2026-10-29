using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Salons.Queries.GetSalons;
using ReservationSystem.Application.Services.Commands.CreateService;
using ReservationSystem.Application.Services.Commands.DeleteService;
using ReservationSystem.Application.Services.Commands.UpdateService;
using ReservationSystem.Application.Services.Queries.GetServiceDetail;
using ReservationSystem.Application.Services.Queries.GetServices;
using ReservationSystem.Persistance;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/services")]
    public class ServicesController : BaseController
    {
        private readonly ReservationDbContext _context;

        public ServicesController(ReservationDbContext context)
        {
                _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceDetailVm>> GetDetail(Guid id)
        {
            var vm = await Mediator.Send(new GetServiceDetailQuery() { ServiceId = id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<ServicesVm>> GetServicesList()
        {
            var services = await _context.Services.AsNoTracking().ToListAsync();
            return Ok(services);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateService(CreateServiceCommand command)
        {
            var serviceId = await Mediator.Send(command);
            return Ok(serviceId);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateService(Guid id, UpdateServiceCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(Guid id)
        {
            await Mediator.Send(new DeleteServiceCommand { ServiceId = id });
            return NoContent();
        }
    }
}
