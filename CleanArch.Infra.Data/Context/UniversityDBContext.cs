using CleanArch.Domains.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<DbContext> options):base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        public DbSet<Course> Courses { get; set; }
    }
}
