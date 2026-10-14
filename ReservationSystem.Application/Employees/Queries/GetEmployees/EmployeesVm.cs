using AutoMapper;
using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Employees.Queries.GetEmployees
{
    public class EmployeesVm : IMapFrom<Employee>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SalonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeesVm>();
        }
    }
}
