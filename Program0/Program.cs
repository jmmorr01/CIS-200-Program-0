// Grading ID: C2937
// Program 0
// Due: 9/11/2017
// Section 200-01
// Description: This test program creates multiple address objects which are used to creater letter objects which are then added to a list of parcels and outputted into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parcel> parcel = new List<Parcel>(); // list to hold multiple parcels.
            var address1 = new Address("Michael Scott", "1725 Slough Avenue", "Scranton", "PA", 18503);
            var address2 = new Address("Abraham Lincoln", "1234 Main Avenue", "Apt 3", "Hodgenville", "Ky", 43201);
            var address3 = new Address("Charlie Kelly", "1538 Paddy Pub Way", "Philadelphia", "PA", 19019);
            var address4 = new Address("Vince McMahon", "1213 avenue", "Building 4", "Pinehurst", "NC", 50483);

            parcel.Add(new Letter(address1, address2, 30));
            parcel.Add(new Letter(address2, address3, 40));
            parcel.Add(new Letter(address3, address4, 10));

            foreach (Letter var in parcel) // Outputs each letter object from the list of parcels into the console.
            {
                Console.WriteLine(var);
            }
        }
    }
}
