using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueCaseStudyIntegrate.Model;

namespace VueCaseStudyIntegrate.Services
{
    public class  CartDbContext : DbContext
    {

        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Cart> cart { get; set; }



    }
}
