﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment3.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public double CalculateTotal()
        {
            return Price * Quantity;
        }

        // Overloaded 
        public double CalculateTotal(double price, int quantity)
        {
            return price * quantity;
        }






    }
}
