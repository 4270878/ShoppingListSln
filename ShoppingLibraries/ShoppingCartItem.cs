using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibraries
{
    public class ShoppingCartItem 

    {
        protected int _productID;
        protected string _productName;
        protected int _quantity;
        protected double _price;
        protected double _subTotal;


        public ShoppingCartItem(int ProductID, string ProductName,
             int Quantity, double Price)
        {
            _productID = ProductID;
            _productName = ProductName;
            _quantity = Quantity;
            _price = Price;
            _subTotal = Quantity * Price;

        }
        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
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
            get { return _quantity * _price; }
        }

    }
}
