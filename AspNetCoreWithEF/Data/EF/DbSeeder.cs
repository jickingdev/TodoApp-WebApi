using AspNetCoreWithEF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithEF.Data.EF
{
    public static class DbSeeder
    {
        public static void Seed(AspNetCoreWithEFContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Todos.Any())
            {
                var todos = new Todo[] { 
                    new Todo(){Description="test a", IsClosed=true},
                    new Todo(){Description="test b"}
                };

                context.Todos.AddRange(todos);
                context.SaveChanges();
            }
        }
    }
}
