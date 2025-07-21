using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04ClosingProjectMain
{
    internal class Computer : BaseMachine // Inherits from BaseMachine
    {
        private int _usbPortSize; // Backing field for USB port size
        public bool IsBluetoothExist { get; set; } // Property to indicate if Bluetooth exists on the computer
        public int UsbPortSize // Property to get or set the USB port size, must be either 2 or 4
        {
            get
            {
                return _usbPortSize; // Returns the current USB port size
            }
            set
            {
                if (value == 2 || value == 4) // Validates the USB port size to be either 2 or 4
                {
                    _usbPortSize = value; // Sets the USB port size if valid
                }
                else
                {
                    _usbPortSize = -1; // Sets to -1 if the value is invalid
                    Console.WriteLine("USB port size must be either 2 or 4."); // Displays an error message if the value is invalid
                } 
            }
        }
            public Computer (string productName, string description, string operatingSystem, string serialNumber, int usbPortSize, bool isBluetoothExist)
        : base(productName, description, operatingSystem, serialNumber) // Calls the base class constructor
        {
            UsbPortSize = usbPortSize;
            IsBluetoothExist = isBluetoothExist;
        }
    public override void DisplayInfo() // Override the DisplayInfo method to include USB port size and Bluetooth information
        {
            base.DisplayInfo();
            Console.WriteLine($"USB Port Size: {UsbPortSize}");
            Console.WriteLine($"Bluetooth Exist: {IsBluetoothExist}");
        }
        public override void GetProductInfo() // Override the GetProductInfo method to display computer-specific information
        {
            Console.WriteLine($"Your computer name is {ProductName}");
        }
    }
}
