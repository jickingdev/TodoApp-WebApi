using AspNetCoreWithEF.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithEF.Data.EF
{
    public class AspNetCoreWithEFContext:DbContext
    {
        public AspNetCoreWithEFContext(DbContextOptions<AspNetCoreWithEFContext> o) : base(o) { }


        public virtual DbSet<Todo> Todos { get; set; }
    }
}
