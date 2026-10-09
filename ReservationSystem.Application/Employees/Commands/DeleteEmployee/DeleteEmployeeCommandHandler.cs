using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IReservationDbContext _context;

        public DeleteEmployeeCommandHandler(IReservationDbContext reservationContext)
        {
            _context = reservationContext;
        }

        public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.Where(e => e.Id == request.EmployeeId).FirstOrDefaultAsync(cancellationToken);

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
