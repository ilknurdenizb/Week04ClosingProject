using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04ClosingProjectMain
{
    internal class Phone : BaseMachine  // Inherits from BaseMachine
    {
        public bool IsTrLicensed { get; set; } // Property to indicate if the phone is TR licensed
        public Phone(string productName, string description, string operatingSystem, string serialNumber, bool isTrLicensed)
     : base(productName, description, operatingSystem, serialNumber) // Calls the base class constructor
        { 
            IsTrLicensed = isTrLicensed;
        }

        public override void DisplayInfo() // Override the DisplayInfo method to include TR license information
        {
            base.DisplayInfo();
            Console.WriteLine($"Lisanslı mı? : {IsTrLicensed}");
           
        }
        public override void GetProductInfo() // Override the GetProductInfo method to display phone-specific information
        {
            Console.WriteLine($"Your phone name is {ProductName}");
        }
    }
    

    
}   
