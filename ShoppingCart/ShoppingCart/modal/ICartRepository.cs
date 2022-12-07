using System.Collections.Generic;

namespace ShoppingCart.modal
{
    public interface ICartRepository
    {
        Cart GetCart(int id);
        IEnumerable<Cart> GetAllCart();
    }
}