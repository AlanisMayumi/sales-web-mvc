using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaleswebMvc.Models
{
    public class SaleswebMvcContext : DbContext
    {
        public SaleswebMvcContext (DbContextOptions<SaleswebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SaleswebMvc.Models.Department> Department { get; set; }
    }
}
