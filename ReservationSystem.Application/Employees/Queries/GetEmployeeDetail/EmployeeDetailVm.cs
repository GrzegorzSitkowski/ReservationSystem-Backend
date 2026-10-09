using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Queries.GetEmployeeDetail
{
    public class EmployeeDetailVm
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SalonId { get; set; }
    }
}
