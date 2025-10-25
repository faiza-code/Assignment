using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Order
    {

        private List<Product> Products;

        public Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double CalculateOrderTotal()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.CalculateTotal();
            }
            return total;
        }
    }
}
