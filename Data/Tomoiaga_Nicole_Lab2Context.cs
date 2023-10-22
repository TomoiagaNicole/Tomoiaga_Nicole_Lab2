using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tomoiaga_Nicole_Lab2.Models;

namespace Tomoiaga_Nicole_Lab2.Data
{
    public class Tomoiaga_Nicole_Lab2Context : DbContext
    {
        public Tomoiaga_Nicole_Lab2Context (DbContextOptions<Tomoiaga_Nicole_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tomoiaga_Nicole_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Tomoiaga_Nicole_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
