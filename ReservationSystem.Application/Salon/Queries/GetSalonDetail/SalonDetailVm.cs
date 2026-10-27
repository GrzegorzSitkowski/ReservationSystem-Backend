using ReservationSystem.Application.Common.Mappings;
using ReservationSystem.Domain.Entities;

namespace ReservationSystem.Application.Salon.Queries.GetSalonDetail
{
    public  class SalonDetailVm : IMapFrom<Domain.Entities.Salon>
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

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Domain.Entities.Salon, SalonDetailVm>();
        }
    }
}
