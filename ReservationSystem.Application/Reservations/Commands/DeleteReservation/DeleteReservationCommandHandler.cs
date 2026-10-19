using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Commands.DeleteReservation
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand>
    {
        private readonly IReservationDbContext _context;

        public DeleteReservationCommandHandler(IReservationDbContext reservationContext)
        {
                _context = reservationContext;
        }

        public async Task Handle (DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Where(r => r.Id == request.ReservationId).FirstOrDefaultAsync(cancellationToken);

            _context.Reservations.Remove(reservation);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
