using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyWorldDbContext:DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options):base(options)
        {

        }
        public DbSet<Beach> Beach{get; set;}
    }
}