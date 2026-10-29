using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Commands.DeleteService
{
    public class DeleteServiceCommand : IRequest
    {
        public Guid ServiceId { get; set; }
    }
}
