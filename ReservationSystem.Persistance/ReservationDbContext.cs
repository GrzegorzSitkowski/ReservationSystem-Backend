using Microsoft.EntityFrameworkCore;

namespace ReservationSystem.Persistance
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options)
            : base(options)
        {
            
        }
    }
}
