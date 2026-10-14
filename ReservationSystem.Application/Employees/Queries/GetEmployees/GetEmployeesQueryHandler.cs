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

namespace ReservationSystem.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, EmployeesVm>
    {
        private readonly IReservationDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IReservationDbContext reservationContext, IMapper mapper)
        {
            _context = reservationContext;
            _mapper = mapper;
        }

        public async Task<EmployeesVm> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _context.Employees.AsNoTracking().
                ProjectTo<EmployeesVm>(_mapper.ConfigurationProvider).ToListAsync();

            return new EmployeesVm();
        }

    }
}
