using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Commands.DeleteSalon
{
    public class DeleteSalonCommandHandler : IRequestHandler<DeleteSalonCommand>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteSalonCommandHandler(IReservationDbContext contextReservation, IMapper mapper)
        {
                _context = contextReservation;
                _mapper = mapper;
        }


        public async Task Handle(DeleteSalonCommand request, CancellationToken cancellationToken)
        {
            var salon = await _context.Salons.Where(s => s.Id == request.SalonId).FirstOrDefaultAsync(cancellationToken);

            _context.Salons.Remove(salon);

            await  _context.SaveChangesAsync(cancellationToken);
        }

    }
}
