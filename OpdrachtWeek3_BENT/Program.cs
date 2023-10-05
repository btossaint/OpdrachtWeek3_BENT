using OpdrachtWeek3_BENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtWeek3_BENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer custom1 = new Customer("Zuyd", "Bob Tossaint", "0612345670");
            Customer custom2 = new Customer("DSM", "Jan Janssen", "0612345671");
            Customer custom3 = new Customer("AMR-ICT", "Frits Klaassen", "0612345672");
            Customer custom4 = new Customer("OpenLine", "Peter Henssen", "0612345673");

            Product prod1 = new Product(1, "PC", "Persenal Computer", 1256.25);
            Product prod2 = new Product(2, "Laptop", "Dell Laptop", 1356.25);
            Product prod3 = new Product(3, "BBQ", "Weber Genisis III", 1456.25);
            Product prod4 = new Product(4, "Pen", "Vulpen", 15.00);

            prod4.ChangeProductPrice(19.00);
            prod4.ChangeProductName("Parker Vulpen");

            Order order1 = new Order("1");
            Order order2 = new Order("2");
            
            order1.AddProduct(prod1,1);
            order1.AddProduct(prod2,5);
            order1.AddProduct(prod3,1);
            order1.SetCustomer(custom3);

            order2.AddProduct(prod4, 100);
            
            order2.SetCustomer(custom4);

            DisplayOrder(order1);       
            DisplayOrder(order2);
            // Verander aantal voor prod 4
            order2.ChangeProductAmount(prod4, 110);
            order1.RemoveProduct(prod1);
            DisplayOrderTotal(order1);
            DisplayOrderTotal(order2);

            EndProgram();
        }

        public static void DisplayOrder(Order order)
        {
            Customer c = order.GetCustomer();
            Console.WriteLine(c.ContactPerson);
            foreach (var p in order.GetProducts())
            {
                Console.WriteLine("Product {0} aantal {1}", p.Item1.Name, p.Item2.ToString());
            }
            Console.WriteLine("-------------------------");
        }

        public static void DisplayOrderTotal(Order order)
        {
            double totalPrice = 0;
            Customer c = order.GetCustomer();
            Console.WriteLine($"Bedrijf       : {c.Companyname}");
            Console.WriteLine($"Contactpersoon: {c.ContactPerson}");
            Console.WriteLine($"Ordernr {order.Number} datum: {order.Date}");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var p in order.GetProducts())
            {
                Console.WriteLine($"Product: {p.Item1.Name,-10} aantal: {p.Item2.ToString()} x {p.Item1.Price:0.00} euro -> {p.Item2 * p.Item1.Price:0.00}");
                totalPrice += (p.Item2 * p.Item1.Price);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Totaal orderbedrag: {totalPrice,34:0.00}");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
        }


        public static void EndProgram()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Druk op enter om af te sluiten.");
            Console.ReadKey();
        }
    }
}
