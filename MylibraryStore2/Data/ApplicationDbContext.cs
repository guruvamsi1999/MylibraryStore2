using Microsoft.EntityFrameworkCore;
using MylibraryStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MylibraryStore2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option): base(option)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
