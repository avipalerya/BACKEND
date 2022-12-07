using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using VueCaseStudyIntegrate.Model;
using VueCaseStudyIntegrate.Repository;

namespace VueCaseStudyIntegrate.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]
    [Route("[Controller]")]

    public class ProductController : ControllerBase
    {
       
        public readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) {
            _productRepository = productRepository;
        }
        
       
        [HttpGet]
        [Route("Product/Get")]
        // [DisableCors]
        public IEnumerable<Product> GetProducts() {
            return _productRepository.GetAllProducts();
        }
        [HttpGet]
        [Route("Product/Get/{id}")]
        public Product GetProductById(int ProductId) {
            return _productRepository.GetProduct(ProductId);
        }
        [HttpPost]
        [Route("Product/Post")]
        public Product AddProduct(Product product) {
            var newproduct = _productRepository.Add(product);
            return (newproduct);
        }
        [HttpDelete]
        [Route("Product/Delete/{id}")]
        public Product DeleteProduct(int ProductId) {
            var delproduct = _productRepository.Delete(ProductId);
            return (delproduct);
        }
    }
}

