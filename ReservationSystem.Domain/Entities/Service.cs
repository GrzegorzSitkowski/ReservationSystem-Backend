using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Entities
{
    public class Service
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public TimeSpan Duration { get; private set; }
        public Guid SalonId { get; private set; }
        public bool IsActive { get; private set; } = true;
    }
}
