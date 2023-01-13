
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domains.Models
{
    public class Role
    {
       
        public Role() => Id = Guid.NewGuid();
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set;}
    }
}
