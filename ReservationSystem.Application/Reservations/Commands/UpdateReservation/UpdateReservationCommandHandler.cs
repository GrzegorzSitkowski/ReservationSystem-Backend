using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;


namespace ReservationSystem.Application.Reservations.Commands.UpdateReservation
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand>
    {
        private readonly IReservationDbContext _context;

        public UpdateReservationCommandHandler(IReservationDbContext reservationContext)
        {
                _context = reservationContext;
        }

        public async Task Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Where(r => r.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

            reservation.CustomerId = request.CustomerId;
            reservation.EmployeeId = request.EmployeeId;
            reservation.ServiceId = request.ServiceId;
            reservation.SalonId = request.SalonId;
            reservation.StartTime = request.StartTime;
            reservation.EndTime = request.EndTime;
            reservation.Notes = request.Notes;
            reservation.Status = request.Status;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
