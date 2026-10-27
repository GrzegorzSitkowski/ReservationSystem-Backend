using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Queries.GetReservations
{
    public class GetReservationsQueryHandler : IRequestHandler<GetReservationsQuery, ReservationsVm>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetReservationsQueryHandler(IReservationDbContext reservationContext, IMapper mapper)
        {
            _context = reservationContext;
            _mapper = mapper;
        }

        public async Task<ReservationsVm> Handle(GetReservationsQuery request, CancellationToken cancellationToken)
        {
            var reservations = await _context.Reservations.AsNoTracking().
                ProjectTo<ReservationsVm>(_mapper.ConfigurationProvider).ToListAsync();

            return new ReservationsVm();
        }
    }
}
