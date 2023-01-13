
using System;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domains.Models
{
    public class User
    {
       
        public User() => Id = Guid.NewGuid();
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
       
      
    }
}
