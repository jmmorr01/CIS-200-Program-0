// Grading ID: C2937
// Program 0
// Due: 9/11/2017
// Section 200-01
// Description: This class takes two address objects and combines them into one parcel object.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        private Address originAddress; // holds information about the Origin Address object
        private Address destinationAddress; // holds information about the Destination Address object.

        // Precondition: None
        // Postcondition: The parcel object will be initalized with the details the user inputs for the two address objects.
        public Parcel(Address originaddress, Address destinationaddress)
        {
            OriginAddress = originaddress;
            DestinationAddress = destinationaddress;
                        
        }

        public Address OriginAddress
        {
            // Precondition: None
            // Postcondition: The Origin Address will be returned.
            get
            {
                return originAddress;
            }
            // Precondition: None
            // Postcondition: Origin Address will be set
            set
            {
                originAddress = value;
            }
        }

        public Address DestinationAddress
        {
            // Precondition: None
            // Postcondition: The Destination Address will be returned.
            get
            {
                return destinationAddress;
            }
            // Precondition: None
            // Postcondition: Destination Address will be set
            set
            {
                destinationAddress = value;
            }
        }
        // Precondition: All variable have recieved valid input.
        // Postcondition: Calculates the cost of the package.
        public abstract decimal CalcCost();

        // Precondition: All previous preconditions have been met.
        // Postcondition: Returns a string that contains formatted details of the package.
        public override string ToString() => "Origin Address: " + System.Environment.NewLine + 
                OriginAddress + System.Environment.NewLine + "Destination Address: " + System.Environment.NewLine + DestinationAddress + System.Environment.NewLine +  
                "Costs: " + CalcCost().ToString("C") + System.Environment.NewLine;
        

    }
}
