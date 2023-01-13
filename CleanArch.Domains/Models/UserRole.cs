using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CleanArch.Domains.Models
{
    public class UserRole
    {
      
        public UserRole() => Id = Guid.NewGuid();
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
