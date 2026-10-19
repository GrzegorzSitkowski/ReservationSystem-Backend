using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Commands.DeleteReservation
{
    public class DeleteReservationCommand : IRequest
    {
        public Guid ReservationId { get; set; }
    }
}
