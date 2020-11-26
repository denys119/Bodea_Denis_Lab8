using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodea_Denis_Lab8.Models;

namespace Bodea_Denis_Lab8.Data
{
    public class Bodea_Denis_Lab8Context : DbContext
    {
        public Bodea_Denis_Lab8Context (DbContextOptions<Bodea_Denis_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bodea_Denis_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bodea_Denis_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bodea_Denis_Lab8.Models.Category> Category { get; set; }
    }
}
