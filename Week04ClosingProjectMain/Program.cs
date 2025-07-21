using System;
using Week04ClosingProjectMain;

class Program
{
    static void Main()
    {
        while (true) // Main loop to allow multiple product creations
        {
            Console.WriteLine("-- Please press 1 to produce Phone or press 2 for production of Computer --");
            string selection = Console.ReadLine();

            if (selection == "1") // Phone creation
            {
                Console.WriteLine("Please enter the product name:");
                string phoneName = Console.ReadLine();

                Console.WriteLine("Please enter the description:");
                string phoneDescription = Console.ReadLine();

                Console.WriteLine("Please enter the operating system:");
                string phoneOperatingSystem = Console.ReadLine();

                Console.WriteLine("Please enter the serial number:");
                string phoneSerialNumber = Console.ReadLine();

                Console.WriteLine("Is it TR licensed? (true/false):");
                bool isTrLicensed = bool.Parse(Console.ReadLine());

                Phone phone = new Phone(phoneName, phoneDescription, phoneOperatingSystem, phoneSerialNumber, isTrLicensed);

                Console.WriteLine("\n--- Product Successfully Created ---");
                phone.GetProductInfo();
                phone.DisplayInfo();
            }
            else if (selection == "2") // Computer creation
            {
                Console.WriteLine("Please enter the product name:");
                string computerName = Console.ReadLine();

                Console.WriteLine("Please enter the description:");
                string computerDescription = Console.ReadLine();

                Console.WriteLine("Please enter the operating system:");
                string computerOperatingSystem = Console.ReadLine();

                Console.WriteLine("Please enter the serial number:");
                string computerSerialNumber = Console.ReadLine();

                Console.WriteLine("Please enter the number of USB ports (2 or 4):");
                int usbPortCount = int.Parse(Console.ReadLine());

                Console.WriteLine("Does it have Bluetooth? (true/false):");
                bool hasBluetooth = bool.Parse(Console.ReadLine());

                Computer computer = new Computer(computerName, computerDescription, computerOperatingSystem, computerSerialNumber, usbPortCount, hasBluetooth);

                Console.WriteLine("\n--- Product Successfully Created ---");
                computer.GetProductInfo();
                computer.DisplayInfo();
            }
            else // For invalid input 
            {
                Console.WriteLine("Invalid input. Please restart and try again.");
            }

            Console.WriteLine("\nDo you want to create another product? (yes/no)");
            string continueInput = Console.ReadLine().ToLower();

            if (continueInput != "yes") // Exit condition
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Clear(); // Clear the console for the next iteration
        }
    }
}
