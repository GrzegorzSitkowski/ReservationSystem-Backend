using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Queries.GetServiceDetail
{
    public class GetServiceDetailQueryHandler : IRequestHandler<GetServiceDetailQuery, ServiceDetailVm>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetServiceDetailQueryHandler(IReservationDbContext contextReservation, IMapper mapper)
        {
            _context = contextReservation;
            _mapper = mapper;
        }

        public async Task<ServiceDetailVm> Handle(GetServiceDetailQuery request, CancellationToken cancellationToken)
        {
            var service = await _context.Services.Where(s => s.Id == request.ServiceId).FirstOrDefaultAsync(cancellationToken);

            var serviceDetailVm = _mapper.Map<ServiceDetailVm>(service);

            return serviceDetailVm;
        }
    }
}
