using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; } 
    }
}
