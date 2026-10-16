using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Queries.GetReservationDetail
{
    public class GetReservationDetailQuery : IRequest<ReservationDetailVm>
    {
        public Guid ReservationId { get; set; }
    }
}
