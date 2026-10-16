using AutoMapper;
using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;
using ReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Reservations.Queries.GetReservations
{
    public class ReservationsVm : IMapFrom<Reservation>
    {
        public Guid Id { get; set; }
        public Guid SalonId { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Reservation, ReservationsVm>();
        }
    }
}
