using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;
using ReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Queries.GetReservationDetail
{
    public class ReservationDetailVm : IMapFrom<Reservation>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid SalonId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string? Notes { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Reservation, ReservationDetailVm>();
        }
    }
}
