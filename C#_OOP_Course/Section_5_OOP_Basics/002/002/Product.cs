using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Product
    {
        private string? _name;
        private double _price;
        private int _quantity;


        // default constructor.
        public Product()
        {
        }

        // overloading constructor.
        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // overloading constructor.
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
            _quantity = 0;
        }


        // Properties. You can use properties to access private fields without GetValue() method.
        public string Name
        {
            get { return _name; }
            set {
                if(value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public double Price
        {
            get { return _price; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        

        public void SetName(string name)
        {
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
        }
        public void SetPrice(double price)
        {
            _price = price;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public double GetPrice()
        {
            return _price;
        }

        public void AddProduct(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            int result = _quantity - quantity;
            if (result < 0)
            {
                _quantity = 0;
                return;
            }
            _quantity -= quantity;
        }

        public void PrintData()
        {
            Console.WriteLine($""
                + $"Product data: {_name}, R${_price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"; {_quantity} units. "
                + $"Total: R${(_price * _quantity).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        // when you call Console.WriteLine(product) this method is called implicitly.
        public override string ToString()
        {
            return _name + $"; R${_price.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"; {_quantity} units. "
                + $"Total: R${(_price * _quantity).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
