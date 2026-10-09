using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Common.Interfaces;
using ReservationSystem.Domain.Entities;

namespace ReservationSystem.Persistance
{
    public class ReservationDbContext : DbContext, IReservationDbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();
        }
    }
}
