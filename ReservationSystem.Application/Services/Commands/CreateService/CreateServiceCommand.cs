using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Commands.CreateService
{
    public class CreateServiceCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid SalonId { get; set; }
    }
}
