using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueCaseStudyIntegrate.Model;

namespace VueCaseStudyIntegrate.Repository
{
   public interface ICartRepository
    {
        Cart GetCart(int CartId);

        public IEnumerable<Cart> GetAllCart();

      

        Cart Add(Cart cart);
        Cart Update(Cart cart);
        Cart Delete(int CartId);
    }
}
