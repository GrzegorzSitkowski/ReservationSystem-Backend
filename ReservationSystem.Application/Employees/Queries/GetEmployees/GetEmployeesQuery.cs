using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQuery : IRequest<EmployeesVm>
    {
    }
}
