using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SalonId { get; set; }
    }
}
