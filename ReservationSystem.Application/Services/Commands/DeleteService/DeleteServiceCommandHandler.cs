using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Commands.DeleteService
{
    public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand>
    {
        private readonly IReservationDbContext _context;

        public DeleteServiceCommandHandler(IReservationDbContext contextReservation)
        {
            _context = contextReservation;
        }

        public async Task Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _context.Services.Where(s => s.Id == request.ServiceId).FirstOrDefaultAsync(cancellationToken);

            _context.Services.Remove(service);
            _context.SaveChangesAsync(cancellationToken);
        }
    }
}
