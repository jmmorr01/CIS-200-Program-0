// Grading ID: C2937
// Program 0
// Due: 9/11/2017
// Section 200-01
// Description: This class uses inherited data from the parcel class to create a letter object which. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel
    {
        private decimal fixedCosts; // holds information about the fixed cost.

        // Precondition: None
        // Postcondition: The letter object will be initalized with the details the user inputs for the two address objects and the fixed cost.
        public Letter(Address originaddress, Address destinationaddress, decimal fixedcosts) : base (originaddress, destinationaddress)
        {
            FixedCosts = fixedcosts;
        }

        public decimal FixedCosts
        {
            // Precondition: None
            // Postcondition: The fixed cost will be returned.
            get
            {
                return fixedCosts;
            }
            // Precondition: value must be non-negative.
            // Postcondition: Origin Address will be set
            set
            {
                if (value >= 0)
                    fixedCosts = value;
                else throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(FixedCosts)} must be non-negative");
            }
        }
        // Precondition: All variable have recieved valid input.
        // Postcondition: Calculates the cost of the package.
        public override decimal CalcCost()
        {
            return fixedCosts;
        }
        // Precondition: All previous preconditions have been met.
        // Postcondition: Returns a string that contains formatted details of the package.
        public override string ToString() => "Origin Address: " + System.Environment.NewLine +
                OriginAddress + System.Environment.NewLine + "Destination Address: " + System.Environment.NewLine + DestinationAddress + System.Environment.NewLine + "Costs: " 
            + CalcCost().ToString("C") + System.Environment.NewLine;
    }
}
