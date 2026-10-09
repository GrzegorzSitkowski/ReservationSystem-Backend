using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeDetailQueryHandler : IRequestHandler<GetEmployeeDetailQuery, EmployeeDetailVm>
    {
        private readonly IReservationDbContext _context;

        public GetEmployeeDetailQueryHandler(IReservationDbContext reservationcContext)
        {
            _context = reservationcContext;
        }

        public async Task<EmployeeDetailVm> Handle(GetEmployeeDetailQuery request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.Where(p => p.Id == request.EmployeeId).FirstOrDefaultAsync(cancellationToken);

            var employeeDetailVm = new EmployeeDetailVm
            {
                Id = employee.Id,
                UserId = employee.UserId,
                SalonId = employee.SalonId
            };

            return employeeDetailVm;
        }
    }
}
