using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class GarageDataContext : DbContext
    {
        public GarageDataContext(DbContextOptions<GarageDataContext> options) : base(options)
        {
        }
        public DbSet<GarageUser> GarageUsers { get; set; }
        
    }
}