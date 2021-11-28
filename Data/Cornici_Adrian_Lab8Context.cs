using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cornici_Adrian_Lab8.Models;

namespace Cornici_Adrian_Lab8.Data
{
    public class Cornici_Adrian_Lab8Context : DbContext
    {
        public Cornici_Adrian_Lab8Context (DbContextOptions<Cornici_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cornici_Adrian_Lab8.Models.Book> Book { get; set; }
    }
}
