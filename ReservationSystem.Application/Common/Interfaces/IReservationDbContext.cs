using Microsoft.EntityFrameworkCore;
using ReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Application.Common.Interfaces
{
    internal interface IReservationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Salon> Salons { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
