using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid SalonId { get; private set; }
    }
}
