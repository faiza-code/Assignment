using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenAssignment.Assignment2
{
    internal class ParkingLotSystem
    {
        static string[] slots = new string[10];
        static void Main (string[] args)
        {
            while (true)
            {
                Console.WriteLine("Parking Lot System Menu:");
                Console.WriteLine("1. Park a Car");
                Console.WriteLine("2. Remove a Car");
                Console.WriteLine("3. View All Slots");
                Console.WriteLine("4. Search for a Car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ParkCar();
                        break;
                    case "2":
                        RemoveCar();
                        break;
                    case "3":
                        ViewSlots();
                        break;
                    case "4":
                        SearchCar();
                        break;
                    case "5":
                        Console.WriteLine("Exiting system...");
                        return;  // Exit program
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ParkCar()
        {
            Console.Write("Enter car license number to park: ");
            string license = Console.ReadLine();

           
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null && slots[i].Equals(license, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("This car is already parked in the lot.");
                    return;
                }
            }

        
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] == null)
                {
                    slots[i] = license;
                    Console.WriteLine($"Car parked in slot #{i + 1}");
                    return;
                }
            }

            Console.WriteLine("Parking lot is full. Cannot park the car.");
        }

        static void RemoveCar()
        {
            Console.Write("Enter car license number to remove: ");
            string license = Console.ReadLine();

            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null && slots[i].Equals(license, StringComparison.OrdinalIgnoreCase))
                {
                    slots[i] = null;
                    Console.WriteLine($"Car with license {license} removed from slot #{i + 1}");
                    return;
                }
            }

            Console.WriteLine("Car not found in the parking lot.");
        }

        static void ViewSlots()
        {
            Console.WriteLine("Current parking slots status:");
            for (int i = 0; i < slots.Length; i++)
            {
                string status = slots[i] ?? "Empty";
                Console.WriteLine($"Slot #{i + 1}: {status}");
            }
        }

        static void SearchCar()
        {
            Console.Write("Enter car license number to search: ");
            string license = Console.ReadLine();

            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null && slots[i].Equals(license, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Car with license {license} is parked in slot #{i + 1}");
                    return;
                }
            }

            Console.WriteLine("Car not found in the parking lot.");
        }
    }
}

