using ShoppingLibraries;
using System.Collections.Generic;
using System;

namespace ShoppingCartApp
{
    internal class Program
    {
        private static ShoppingCartItem ShoppingCartItem(string v1, double v2)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {

            ShoppingCart shoppingCart = new ShoppingCart();
         
            ShoppingCartItem item = ShoppingCartItem("XBox", 5125.00);
            shoppingCart.ShoppingCartItem(item);

            item = new ShoppingCartItem("Huawei P40 pro", 14520.99);
            shoppingCart.ShoppingCartItem(item);

            item = new ShoppingCartItem("iPad", 9520.99);
            shoppingCart.ShoppingCartItem(item);

            List<ShoppingCartItem> items = shoppingCart.CartList();

            foreach (ShoppingCartItem i in items)
            {
                Console.WriteLine(i.ProductName + " " + 'R' +Math.Round(i.Price, 2));
            }

            Console.WriteLine("Sub total: " + 'R'+shoppingCart.SubTotal());
            Console.WriteLine("With Vat: " + 'R' + shoppingCart.SubTotalVat());
            
            
        }
    }
}
