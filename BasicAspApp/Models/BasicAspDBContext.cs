using System;
using Microsoft.EntityFrameworkCore;

namespace BasicAspApp.Models
{
    public class BasicAspDBContext: DbContext
    {
        public BasicAspDBContext()
        {
        }
        public BasicAspDBContext(DbContextOptions<BasicAspDBContext> options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
