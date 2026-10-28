using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Queries.GetServiceDetail
{
    public class ServiceDetailVm : IMapFrom<Service>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Service, ServiceDetailVm>();
        }
    }
}
