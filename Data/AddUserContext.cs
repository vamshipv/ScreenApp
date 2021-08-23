using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Screens.Models;

namespace Screens.Data
{
    public class AddUserContext : DbContext
    {
        public AddUserContext(DbContextOptions<AddUserContext> options)
            : base(options)
        {
        }

        public DbSet<Screens.Models.AddUser> AddUser { get; set; }
        public DbSet<Screens.Models.AddProject> AddProject { get; set; }
    }
}