using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Services.Queries.GetServiceDetail
{
    public class GetServiceDetailQuery : IRequest<ServiceDetailVm>
    {
        public Guid ServiceId { get; set; }
    }
}
