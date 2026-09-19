using ReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Guid ServiceId { get; private set; }
        public Guid SalonId { get; private set; }
        public DateTimeOffset StartTime { get; private set; }
        public DateTimeOffset EndTime { get; private set; }
        public string? Notes { get; private set; }
        public ReservationStatus Status { get; private set; } = ReservationStatus.Pending;
    }
}
