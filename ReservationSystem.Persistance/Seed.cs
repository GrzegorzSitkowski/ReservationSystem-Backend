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
            ModelBuilder.Entity<Salon>(s =>
            {
                s.HasData(new Salon()
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Salon A",
                    Address = "123 Main St",
                });
            });
        }
    }
}
