using AspNetCoreWithEF.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithEF.Data.EF
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> o) : base(o) { }


        public virtual DbSet<Todo> Todos { get; set; }
    }
}
