using ReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public UserRole Role { get; private set; } 
        public string PasswordHash { get; private set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow; 
        public DateTimeOffset UpdatedAt { get; private set; }
        public bool IsActive { get; private set; } = true;
    }
}
