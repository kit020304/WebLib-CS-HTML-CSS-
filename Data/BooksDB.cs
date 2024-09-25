using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebLib.Models;

namespace WebLib.Data
{
    public class BooksDB : DbContext
    {
        public BooksDB (DbContextOptions<BooksDB> options)
            : base(options)
        {
        }

        public DbSet<WebLib.Models.Books> Books { get; set; } = default!;
    }
}
