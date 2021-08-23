using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> op) : base(op)
        {
        }
        public DbSet<MovementRecord> MovementRecords { get; set; }
        public DbSet<MoveType> MoveTypes { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
