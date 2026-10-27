using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Queries.GetSalonDetail
{
    public class GetSalonDetailQuery : IRequest<SalonDetailVm>
    {
        public Guid SalonId { get; set; }
    }
}
