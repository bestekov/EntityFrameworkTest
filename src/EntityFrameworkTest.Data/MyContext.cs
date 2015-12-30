using Microsoft.Data.Entity;
using System;

namespace EntityFrameworkTest.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Model> Models { get; set; }
    }
}


