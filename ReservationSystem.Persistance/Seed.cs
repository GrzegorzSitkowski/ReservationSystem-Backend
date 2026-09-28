using Microsoft.EntityFrameworkCore;
using ReservationSystem.Domain.Entities;
using ReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    SalonId = Guid.Parse("11111111-1111-1111-1111-111111111111")
                });
            });

            modelBuilder.Entity<Reservation>(r =>
            {
                r.HasData(new Reservation()
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    CustomerId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    EmployeeId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    ServiceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    SalonId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    StartTime = DateTimeOffset.Now.AddDays(1),
                    EndTime = DateTimeOffset.Now.AddDays(1).AddHours(1),
                    Notes = "Please be on time.",
                    Status = ReservationStatus.Pending
                });
            });

            modelBuilder.Entity<Salon>(s =>
            {
                s.HasData(new Salon()
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Salon XYZ",
                    Address = "Hetmańska 15, Poznań",
                    PhoneNumber = "123-456-789",
                    Email = "xyz@gmail.com",
                    Description = "Barber shop.",
                    OwnerId = Guid.Parse("22222222-2222-2222-2222-222222222222")
                });
            });

            modelBuilder.Entity<Service>(se =>
            {
                se.HasData(new Service()
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Name = "Strzyżenie krótkich włosów.",
                    Description = "Czas ok. 30 min.",
                    Duration = TimeSpan.FromMinutes(30),
                    Price = 30.00m,
                    SalonId = Guid.Parse("11111111-1111-1111-1111-111111111111")
                });
            });
        }
    }
}
