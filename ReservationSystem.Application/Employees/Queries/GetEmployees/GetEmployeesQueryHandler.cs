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

        public GetEmployeesQueryHandler(IReservationDbContext reservationContext)
        {
            _context = reservationContext;
        }

        public async Task<EmployeesVm> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _context.Employees.AsNoTracking().ToListAsync();

            return new EmployeesVm();
        }

    }
}
