using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueCaseStudyIntegrate.Model;

namespace VueCaseStudyIntegrate.Services
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Product> product { get; set; }



    }
}
