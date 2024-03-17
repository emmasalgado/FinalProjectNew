using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectNew.Models;

namespace FinalProjectNew.Data
{
    public class LeaveContext : DbContext
    {
        public LeaveContext (DbContextOptions<LeaveContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectNew.Models.LeaveRequest> LeaveRequest { get; set; } = default!;
    }
}
