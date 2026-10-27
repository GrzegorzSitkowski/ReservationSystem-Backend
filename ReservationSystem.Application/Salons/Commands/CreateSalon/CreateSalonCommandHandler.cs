using MediatR;
using ReservationSystem.Application.Common.Interfaces;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Commands.CreateSalon
{
    public class CreateSalonCommandHandler : IRequestHandler<CreateSalonCommand, Guid>
    {
        private readonly IReservationDbContext _context;

        public CreateSalonCommandHandler(IReservationDbContext reservationContext)
        {
            _context = reservationContext;
        }

        public async Task<Guid> Handle(CreateSalonCommand request, CancellationToken cancellationToken)
        {
            Salon salon = new()
            {
                Name = request.Name,
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Description = request.Description,
                OwnerId = request.OwnerId,
            };

            _context.Salons.Add(salon);
            await _context.SaveChangesAsync(cancellationToken);

            return salon.Id;
        }
    }
}
