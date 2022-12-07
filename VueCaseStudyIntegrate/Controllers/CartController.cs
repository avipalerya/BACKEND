
using Microsoft.AspNetCore.Mvc;
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

    public class CartController : ControllerBase
    {

        public readonly ICartRepository _cartRepository;
        public CartController(ICartRepository cartRepository) {
            _cartRepository = cartRepository;
        }


        [HttpGet]
        [Route("Cart/Get")]
        // [DisableCors]
        public IEnumerable<Cart> GetCart() {
            return _cartRepository.GetAllCart();
        }
        [HttpGet]
        [Route("Cart/Get/{id}")]
        public Cart GetCartById(int CartId) {
            return _cartRepository.GetCart(CartId);
        }
        [HttpPost]
        [Route("Cart/Post")]
        public Cart AddCart(Cart cart) {
            var newcart = _cartRepository.Add(cart);
            return (newcart);
        }
        [HttpDelete]
        [Route("Cart/Delete/{id}")]
        public Cart DeleteCart(int CartId) {
            var delcart = _cartRepository.Delete(CartId);
            return delcart;
        }
    }
}

