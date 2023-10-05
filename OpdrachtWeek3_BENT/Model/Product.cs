using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtWeek3_BENT.Model
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;

        public Product(int _id, string _name, string _description, double _price)
        {
            id = _id;
            name = _name;
            description = _description;
            price = _price;
        }

        public string Name { get => name;  }
        public double Price { get => price; }
        public int Id { get => id; }

        public void ChangeProductName(string _name)
        { 
            name = _name;
        }

        public void ChangeProductPrice(double _price)
        {
            if (_price != null && _price > 0)
            {
                price = _price;
            }
        }



    }
}
