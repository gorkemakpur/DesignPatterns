using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//veritabanını ayağa kaldırmak için kullanıyoruz
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-SVROI9OR\\SQLEXPRESS;" +
                "initial catalog=CompositeDesignPattern; integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
