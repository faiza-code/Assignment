using MakeenAssignment.Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3
{
    public class E_CommerceMain
    {
        static void Main(string[] args)
        {
           
            Product product1 = new Product("iphone 17 pro max", 600.90, 1);
            Product product2 = new Product("MacBook Air",500.98,1);
            product2.Name = "AirPods";
            product2.Price = 50.20;
            product2.Quantity = 1;

            
            double Total = product2.CalculateTotal(30.00, 3);

            Console.WriteLine($"Custom Total for product2: {Total:C}");

           
            Order order = new Order();
            order.AddProduct(product1);
            order.AddProduct(product2);

          
            double orderTotal = order.CalculateOrderTotal();
            Console.WriteLine($"Order Total: {orderTotal:C}");
        }
    }
}
