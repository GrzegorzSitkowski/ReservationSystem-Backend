using AutoMapper;
using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Queries.GetEmployeeDetail
{
    public class EmployeeDetailVm : IMapFrom<Employee>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SalonId { get; set; }

        public void Mappiing(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeDetailVm>();
        }
    }
}
