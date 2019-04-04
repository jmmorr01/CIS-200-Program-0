// Grading ID: C2937
// Program 0
// Due: 9/11/2017
// Section 200-01
// Description: This class takes in information about a sender/reciever of a package (name, address, state, city, zip) 
// and validates it and formats it to be used later when creating a parcel/letter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        private const int MAX_ZIP = 99999; // constant used for zip validation
        private const int MIN_ZIP = 00000; // constant used for zip validation

        private string name; // used to store the name of the sender
        private string addressOne; // used to store the first address line of the sender/reciever
        private string addressTwo; // used to store the second address line of sender/reciever
        private string city; // used to store the city of the sender/reciever
        private string state; // used to store the state of the sender/reciever
        private int zipCode; // used to store the zipcode of the sender/reciever

        // Precondition: None
        // Postcondition: The address object will have been initalized with the values the user inputs for the corresponding parts of the package
        public Address(string name, string address1, string address2, string city, string state, int zipcode)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zipcode;
           
        }
        // Precondition: None
        // Postcondition: The address object will have been initalized with the values the user inputs for the corresponding parts of the package (everything except address line two)
        public Address(string name, string address1, string city, string state, int zipcode)
        {
            Name = name;
            Address1 = address1;
            addressTwo = "";
            City = city;
            State = state;
            Zip = zipcode;
           
        }

        public string Name
        {
            // Precondition: None
            // Postcondition: The name will be returned.
            get
            {
                return name;
            }
            // Precondition: Name has to be valid string
            // Postcondition: Name will be set
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Name)} must not be empty or whitespace");
                }
            }
        }

        public string Address1
        {
            // Precondition: None
            // Postcondition: The Address will be returned.
            get
            {
                return addressOne;
            }
            // Precondition: Address has to be valid string
            // Postcondition: Address will be set
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    addressOne = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Address1)} must not be empty or whitespace");
                }
            }
        }

        public string Address2
        {
            // Precondition: None
            // Postcondition: The Address will be returned.
            get
            {
                return addressTwo;
            }
            // Precondition: Address has to be valid string
            // Postcondition: Address will be set
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    addressTwo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Address2)} must not be empty or whitespace");
                }
            }
        }

        public string City
        {
            // Precondition: None
            // Postcondition: The City will be returned.
            get
            {
                return city;
            }
            // Precondition: City has to be valid string
            // Postcondition: City will be set
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    city = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(City)} must not be empty or whitespace");
                }
            }
        }

        public string State
        {
            // Precondition: None
            // Postcondition: The State will be returned.
            get
            {
                return state;
            }
            // Precondition: State has to be valid string
            // Postcondition: State will be set
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(State)} must not be empty or whitespace");
                }
            }
        }

        public int Zip
        {
            // Precondition: None
            // Postcondition: The Zip will be returned.
            get
            {
                return zipCode;
            }
            // Precondition: 00000 < value < 99999
            // Postcondition: Zip will be set
            set
            {
                if ((value > MIN_ZIP) && (value < MAX_ZIP))
                {
                    zipCode = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Zip)} must be > {MIN_ZIP} and < {MAX_ZIP}");
                }
            }
        }
        // Precondition: All previous preconditions have been met.
        // Postcondition: Returns a string that contains formatted details of the package.
        public override string ToString() => name.ToString() + System.Environment.NewLine +
            addressOne.ToString() + System.Environment.NewLine + addressTwo.ToString() + System.Environment.NewLine +
            city.ToString() +  " " + state.ToString() +  " " + zipCode.ToString("D5") + System.Environment.NewLine;
    }
}
