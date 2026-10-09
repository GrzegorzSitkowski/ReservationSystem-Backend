using MediatR;
using ReservationSystem.Application.Common.Interfaces;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Guid>
    {
        private readonly IReservationDbContext _context;
        public CreateEmployeeCommandHandler(IReservationDbContext reservationContext)
        {
                _context = reservationContext;
        }
        public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = new()
            {
                UserId = request.UserId,
                SalonId = request.SalonId
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync(cancellationToken);

            return employee.Id;
        }
    }
}
