using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Commands.UpdateSalon
{
    public class UpdateSalonCommandHandler : IRequestHandler<UpdateSalonCommand>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public UpdateSalonCommandHandler(IReservationDbContext reservationContext, IMapper mapper)
        {
                _context = reservationContext;
                _mapper = mapper;
        }

        public async Task Handle(UpdateSalonCommand request, CancellationToken cancellation)
        {
            var salon = await _context.Salons.Where(s => s.Id == request.Id).FirstOrDefaultAsync(cancellation);

            salon.Name = request.Name;
            salon.Address = request.Address;
            salon.PhoneNumber = request.PhoneNumber;
            salon.Email = request.Email;
            salon.Description = request.Description;
            salon.OwnerId = request.OwnerId;

            await _context.SaveChangesAsync(cancellation);
        }
    }
}
