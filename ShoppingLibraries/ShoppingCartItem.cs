using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibraries
{
    public class ShoppingCartItem 

    {
        protected string _productName;
        protected double _price;
        protected double _subTotal;


        public ShoppingCartItem(int ProductID, string ProductName,
             int Quantity, double Price)
        {
            _productName = ProductName;
            _price = Price;
            _subTotal = 0.15 * Price;

        }

        public ShoppingCartItem(string productName, double price)
        {
            this._productName = productName;
            this._price = price;
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public static explicit operator ShoppingCartItem(ShoppingCart v)
        {
            throw new NotImplementedException();
        }
     
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double SubTotal
        {
            get { return 0.15 * _price; }
        }

    }
}
