using MediatR;
using ReservationSystem.Application.Common.Interfaces;
using ReservationSystem.Domain.Entities;


namespace ReservationSystem.Application.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, Guid>
    {
        private readonly IReservationDbContext _context;

        public CreateServiceCommandHandler(IReservationDbContext contextReservation)
        {
                _context = contextReservation;
        }

        public async Task<Guid> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            Service service = new()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Duration = request.Duration,
                SalonId = request.SalonId,
            };

            _context.Services.Add(service);
            await _context.SaveChangesAsync(cancellationToken);

            return service.Id;

        }
    }
}
