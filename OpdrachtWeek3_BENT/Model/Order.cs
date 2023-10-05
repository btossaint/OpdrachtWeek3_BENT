using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtWeek3_BENT.Model
{
    public class Order
    {
        private DateTime date = new DateTime();
        private string number;
        private List<Tuple<Product, int>> products = new List<Tuple<Product, int>>();
        private Customer customer;
        
        
        public string Number { get => number;  }
        public DateTime Date { get => date;  }        

        public Order(string ONumber)
        {
            date = DateTime.Now;
            number = ONumber;
        }

        public void SetCustomer(Customer _customer)
        {
            customer = _customer;
        }
        public Customer GetCustomer()
        {
            return customer;
        }
        public void AddProduct(Product _product, int _amount)
        {
            products.Add(new Tuple<Product,int>(_product,_amount));
        }

        public void RemoveProduct(Product _product)
        {
            int index = products.FindIndex(t => t.Item1 == _product);

            if (index != -1)
            {
                // Remove:
                products.RemoveAt(index);
            }            
        }

        public void ChangeOrderDate(DateTime _date)
        {
            date = _date.Date;
        }

        public void ChangeProductAmount(Product _product, int _amount)
        {
            RemoveProduct(_product);
            AddProduct(_product, _amount);
        }
     
        public List<Tuple<Product, int>> GetProducts()
        {
            return products;
        }
    }
}
