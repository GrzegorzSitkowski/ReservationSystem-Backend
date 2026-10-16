using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Queries.GetReservationDetail
{
    public class GetReservationDetailQueryHandler : IRequestHandler<GetReservationDetailQuery, ReservationDetailVm>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetReservationDetailQueryHandler(IReservationDbContext reservationContext, IMapper mapper)
        {
            _context = reservationContext;
            _mapper = mapper;
        }

        public async Task<ReservationDetailVm> Handle(GetReservationDetailQuery request, CancellationToken cancellationToken)
        {
            var reservation = await _context.Reservations.Where(p => p.Id == request.ReservationId).FirstOrDefaultAsync(cancellationToken);

            var reservationDetailVm = _mapper.Map<ReservationDetailVm>(reservation);

            return reservationDetailVm;
        }
    }
}
