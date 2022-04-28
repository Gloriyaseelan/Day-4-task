using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFcore1.Models;

namespace EFcore1.Models
{
    public class ProductDBcontext : DbContext
    {
        public ProductDBcontext()
        {

        }
        public ProductDBcontext(DbContextOptions<ProductDBcontext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=GUNA;Initial Catalog=Trail;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Product> Products { get; set; }
    }
    

}
