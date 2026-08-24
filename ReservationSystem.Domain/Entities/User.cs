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
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required Role Roles { get; set; } //= new List<Role>();
        public required string PasswordHash { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now; 
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
