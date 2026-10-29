using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Commands.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IReservationDbContext _context;

        public UpdateServiceCommandHandler(IReservationDbContext contextReservation)
        {
            _context = contextReservation;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _context.Services.Where(s => s.Id == request.SalonId).FirstOrDefaultAsync(cancellationToken);

            service.Name = request.Name;
            service.Description = request.Description;
            service.Price = request.Price;
            service.Duration = request.Duration;
            service.SalonId = request.SalonId;

            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
