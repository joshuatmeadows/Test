using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MIST353GroupProjectSlickSnakes.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        //public DbSet<Hotel> Hotel { get; set; }
    }
}
