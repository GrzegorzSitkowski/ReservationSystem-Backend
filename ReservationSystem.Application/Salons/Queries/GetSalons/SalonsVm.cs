using ReservationSystem.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Salons.Queries.GetSalons
{
    public class SalonsVm : IMapFrom<Domain.Entities.Salon>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? Description { get; set; }
        public Guid OwnerId { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
