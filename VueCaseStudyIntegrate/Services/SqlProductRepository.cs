using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueCaseStudyIntegrate.Model;
using VueCaseStudyIntegrate.Repository;

namespace VueCaseStudyIntegrate.Services
{
    public class  SqlProductRepository : IProductRepository
    {

        private readonly ProductDbContext context;
        public SqlProductRepository(ProductDbContext context) {
            this.context = context;
        }

        public Product Add(Product product) {
            context.Add(product);
            context.SaveChanges();
            return product;
        }



        public Product Delete(int ProductId) {
            Product product = context.product.Find(ProductId);
            if (product != null) {
                context.product.Remove(product);
                context.SaveChanges();
            }
            return product;
        }


        public IEnumerable<Product> GetAllProducts() {
            return context.product;
        }



        public Product GetProduct(int ProductId) {
            return context.product.Find(ProductId);
        }

        public Product Update(Product ProductDbContext) {
            var product = context.product.Attach(ProductDbContext);

            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ProductDbContext;

        }


    }
}

