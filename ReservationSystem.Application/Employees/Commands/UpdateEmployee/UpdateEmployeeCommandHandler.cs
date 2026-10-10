using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IReservationDbContext _context;
        public UpdateEmployeeCommandHandler(IReservationDbContext reservationContext)
        {
            _context = reservationContext;
        }
        public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _context.Employees.Where(e => e.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (employee != null)
            {
                employee.UserId = request.UserId;
                employee.SalonId = request.SalonId;
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
