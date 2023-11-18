using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Edmond_Ferenc_Lab2.Models;

namespace Muresan_Edmond_Ferenc_Lab2.Data
{
    public class Muresan_Edmond_Ferenc_Lab2Context : DbContext
    {
        public Muresan_Edmond_Ferenc_Lab2Context (DbContextOptions<Muresan_Edmond_Ferenc_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Borrowing>? Borrowing { get; set; }
       // public DbSet<Muresan_Edmond_Ferenc_Lab2.Models.Author>? Authors { get; set; } = default!;

    }
}
