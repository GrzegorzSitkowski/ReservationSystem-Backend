using Microsoft.EntityFrameworkCore;
using ReservationSystem.Domain.Entities;
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
        }
    }
}
