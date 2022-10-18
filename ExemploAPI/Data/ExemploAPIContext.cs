using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExemploAPI.Model;

namespace ExemploAPI.Data
{
    public class ExemploAPIContext : DbContext
    {
        public ExemploAPIContext (DbContextOptions<ExemploAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ExemploAPI.Model.Person> Person { get; set; }

        public DbSet<ExemploAPI.Model.Adress> Adress { get; set; }
    }
}
