using Microsoft.EntityFrameworkCore;
using ProductCrud.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
