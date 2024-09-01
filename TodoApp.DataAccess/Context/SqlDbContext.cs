using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Entity.Entities;

namespace TodoApp.DataAccess.Context
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
