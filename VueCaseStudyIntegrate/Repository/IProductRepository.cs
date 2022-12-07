using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueCaseStudyIntegrate.Model;

namespace VueCaseStudyIntegrate.Repository
{
     public interface IProductRepository
    {
        Product GetProduct(int ProductId);

        public IEnumerable<Product> GetAllProducts();


        Product Add(Product product);
        Product Update(Product product);
        Product Delete(int ProductId);
    }
}
