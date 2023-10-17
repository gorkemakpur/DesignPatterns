using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//veritabanını ayağa kaldırmak için kullanıyoruz
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-SVROI9OR\\SQLEXPRESS;initial catalog=DesignPattern1; integrated security=true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
