using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salon.Queries.GetSalonDetail
{
    public class GetSalonDetailQueryHandler : IRequestHandler<GetSalonDetailQuery, SalonDetailVm>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetSalonDetailQueryHandler(IReservationDbContext reservationContext, IMapper mapper)
        {
            _context = reservationContext;
            _mapper = mapper;
        }

        public async Task<SalonDetailVm> Handle(GetSalonDetailQuery request, CancellationToken cancellationToken)
        {
            var salon = await _context.Salons.Where(s => s.Id == request.SalonId).FirstOrDefaultAsync(cancellationToken);

            var salonDetailVm = _mapper.Map<SalonDetailVm>(salon);

            return salonDetailVm;
        }
    }
}
