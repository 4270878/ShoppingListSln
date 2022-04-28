using System;
using System.Collections.Generic;

namespace ShoppingLibraries
{

    public class ShoppingCart 
    {
        protected int _productID;
        protected string _productName;
        protected int _quantity;
        protected double _price;
        protected double _subTotal;


        public ShoppingCart(int ProductID, string ProductName,
             int Quantity, double Price)
        {
            _productID = ProductID;
            _productName = ProductName;
            _quantity = Quantity;
            _price = Price;
            _subTotal = Quantity * Price;

        }

        private DateTime _dateCreated;
        private DateTime _lastUpdate;
        private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();
        private object _item;

        public ShoppingCart()
        {
            if (this._items == null)
            {
                this._items = new List<ShoppingCartItem>();
                this._dateCreated = DateTime.Now;
            }
        }
        public List<ShoppingCart> Items
        {
            get { return Items; }
            set { Items = value; }
            
        }

        public object Item { get; private set; }

        public void Insert(int ProductID, double Price, int Quantity, string ProductName)
        {
            int ItemIndex = ItemIndexOfID(ProductID);
            if (ItemIndex == -1)
            {
               ShoppingCart cart = new ShoppingCart(); ;
                cart._productID = ProductID;
                cart._quantity = Quantity;
                cart._price = Price;
                cart._productName = ProductName;
                _items.Add((ShoppingCartItem)cart);
            }
            else
            {
                _items[ItemIndex].Quantity += 1;
            }
            _lastUpdate = DateTime.Now;
        }

        private int ItemIndexOfID(int productID)
        {
            throw new NotImplementedException();
        }

        public void Update(int RowID, int ProductID, int Quantity, double Price)
        {
            ShoppingCart Item = Items[RowID];
            Item._productID = ProductID;
            Item._quantity = Quantity;
            Item._price = Price;
            _lastUpdate = DateTime.Now;
        }

        public void DeleteItem(int rowID)
        {
            _items.RemoveAt(rowID);
            _lastUpdate= DateTime.Now;
        }
        private int count (int ProductID)
        {
            int index = 0;
            foreach (ShoppingCart cart in _items)
            {
                if (_item.ProductID == ProductID)
                {
                    return index;
                }
                index += 1;
            }
            return -1;
        }
        public double SubTotal()
        {
            double total = 0;
            foreach(ShoppingCart cart in _items)
            {
                total += Item.Price;
            }
            return Math.Abs(total);
        }

   
   
}


