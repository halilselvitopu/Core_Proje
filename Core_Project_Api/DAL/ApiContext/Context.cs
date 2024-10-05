using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-7BBVMRE\\SQLEXPRESS;database=CorePortfolioDb2;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
