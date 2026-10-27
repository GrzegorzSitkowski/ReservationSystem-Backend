using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Reservations.Commands.CreateReservation;
using ReservationSystem.Application.Reservations.Commands.DeleteReservation;
using ReservationSystem.Application.Reservations.Commands.UpdateReservation;
using ReservationSystem.Application.Reservations.Queries.GetReservationDetail;
using ReservationSystem.Application.Reservations.Queries.GetReservations;
using ReservationSystem.Persistance;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/reservations")]
    public class ReservationsController : BaseController
    {
        private readonly ReservationDbContext _context;

        public ReservationsController(ReservationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetailVm>> GetDetails (Guid id)
        {
            var vm = await Mediator.Send(new GetReservationDetailQuery() { ReservationId = id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<ReservationsVm>> GetReservationsList()
        {
            var reservations = await _context.Reservations.AsNoTracking().ToListAsync();
            return Ok(reservations);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateReservation(CreateReservationCommand command)
        {
            var reservationId = await Mediator.Send(command);
            return Ok(reservationId);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateReservation(Guid id, [FromBody] UpdateReservationCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(Guid id)
        {
            await Mediator.Send(new DeleteReservationCommand { ReservationId = id });
            return NoContent();
        }
    }
}
