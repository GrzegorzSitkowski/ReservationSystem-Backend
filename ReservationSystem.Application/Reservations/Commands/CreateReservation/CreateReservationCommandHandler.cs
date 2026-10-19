using MediatR;
using ReservationSystem.Application.Common.Interfaces;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IReservationDbContext _context;

        public CreateReservationCommandHandler(IReservationDbContext reservationDbContext)
        {
                _context = reservationDbContext;
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken) 
        {
            Reservation reservation = new()
            {
                CustomerId = request.CustomerId,
                EmployeeId = request.EmployeeId,
                ServiceId = request.ServiceId,
                SalonId = request.SalonId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                Notes = request.Notes,
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);

            return reservation.Id;
        }
    }
}
