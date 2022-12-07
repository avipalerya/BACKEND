using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loosentightcoupling
{
   public class Shopping
    {
        public float price = 20;
        public int quantity = 2;

    }
    public class ShoppingCart
    {
        public Shopping[] items;
    }
    public class Order 
    {
        

        private ShoppingCart cart;
        private float salesTax;

        public Order(ShoppingCart cart, float salesTax) {
            this.cart = cart;
            this.salesTax = salesTax;
        }
        public float OrderTotal() {
            float Carttotal = 0;
            
            for (int i=0;i< cart.items.Length; i++) {
                Carttotal += cart.items[i].price * cart.items[i].quantity;

            }
            Carttotal += Carttotal * salesTax;
            return Carttotal;
        }

    }
}
