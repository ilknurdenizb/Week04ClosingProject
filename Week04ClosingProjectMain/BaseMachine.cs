using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04ClosingProjectMain
{
    internal abstract class BaseMachine // Base class for all machines
    {
        public DateTime ProductionDate { get; } = DateTime.Now; // Production date is set to the current date and time
        public string SerialNumber { get; set; } // Serial number of the machine, can be set externally
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public BaseMachine(string productName, string description, string operatingSystem, string serialNumber) // Constructor to initialize the machine with product name, description, operating system, and serial number
        {
            ProductName = productName;
            Description = description;
            OperatingSystem = operatingSystem;
            SerialNumber = serialNumber;
        }

        public virtual void DisplayInfo() // Virtual method to display basic information about the machine
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Operating System: {OperatingSystem}");
            Console.WriteLine($"Serial Number: {SerialNumber}");
            Console.WriteLine($"Production Date: {ProductionDate.ToShortDateString()}");
        }
        public abstract void GetProductInfo(); // Abstract method to be implemented by derived classes to get specific product information
    }

}
