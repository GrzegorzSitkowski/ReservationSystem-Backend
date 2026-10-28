using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Commands.DeleteSalon
{
    public class DeleteSalonCommand : IRequest
    {
        public Guid SalonId { get; set; }
    }
}
