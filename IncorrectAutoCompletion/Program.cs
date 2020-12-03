using System;
using Microsoft.EntityFrameworkCore;

namespace IncorrectAutoCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Foo
    {
        public string Bar { get; set; }
    }

    class Fiz : DbContext
    {
        public DbSet<Foo> Foos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Foo>(e =>
            {
                //typing e.HasIndex(p<space> 
                //autocompletes to e.HasIndex(prop
            });
        }
    }
}
