using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Persistance
{
    internal class ReservationDbContextFactory : DesignTimeDbContextFactoryBase<ReservationDbContext>
    {
        protected override ReservationDbContext CreateNewInstance(DbContextOptions<ReservationDbContext> options)
        {
            return new ReservationDbContext(options);
        }
    }
}
