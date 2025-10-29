using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    public class InventoryManagementSystem
    {
        static string[] products = { "Apple", "Orange", "Milk" };
        static int[] quantities = { 10, 20, 15 };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Inventory Management System:");
                Console.WriteLine("1. View All Products");
                Console.WriteLine("2. Add Stock");
                Console.WriteLine("3. Sell Product");
                Console.WriteLine("4. Check Product Quantity");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewAllProducts();
                        break;
                    case "2":
                        AddStock();
                        break;
                    case "3":
                        SellProduct();
                        break;
                    case "4":
                        CheckProductQuantity();
                        break;
                    case "5":
                        Console.WriteLine("Exiting system...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ViewAllProducts()
        {
            Console.WriteLine("Product Stock List:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} - Quantity: {quantities[i]}");
            }
        }

        static void AddStock()
        {
            Console.Write("Enter product name to add stock: ");
            string product = Console.ReadLine();
            int index = FindProductIndex(product);
            if (index == -1)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity to add: ");
            if (int.TryParse(Console.ReadLine(), out int qty) && qty > 0)
            {
                quantities[index] += qty;
                Console.WriteLine($"Added {qty} units to {products[index]}. Total: {quantities[index]}");
            }
            else
            {
                Console.WriteLine("Invalid quantity.");
            }
        }

        static void SellProduct()
        {
            Console.Write("Enter product name to sell: ");
            string product = Console.ReadLine();
            int index = FindProductIndex(product);
            if (index == -1)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity to sell: ");
            if (int.TryParse(Console.ReadLine(), out int qty) && qty > 0)
            {
                if (quantities[index] >= qty)
                {
                    quantities[index] -= qty;
                    Console.WriteLine($"Sold {qty} units of {products[index]}. Remaining: {quantities[index]}");
                }
                else
                {
                    Console.WriteLine($"Insufficient stock. Only {quantities[index]} units available.");
                }
            }
            else
            {
                Console.WriteLine("Invalid quantity.");
            }
        }

        static void CheckProductQuantity()
        {
            Console.Write("Enter product name to check quantity: ");
            string product = Console.ReadLine();
            int index = FindProductIndex(product);
            if (index == -1)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.WriteLine($"{products[index]} has {quantities[index]} units in stock.");
        }

        static int FindProductIndex(string productName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
