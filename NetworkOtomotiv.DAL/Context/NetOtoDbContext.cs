using Microsoft.EntityFrameworkCore;
using NetworkOtomotiv.Entity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.DAL.Context
{
    public class NetOtoDbContext  : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=NetOtoDb; Trusted_Connection=true; TrustServerCertificate=true");
        }
    }
}
