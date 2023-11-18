using System;
 
namespace Lesson11.Models
{
	 internal class Address
	 {
		public string street;
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
		public string HouseNumber { get; set; }
		   
		public Address()
		{
			Country = "Uzbekistan";
			Region = "Tashkent";
			District = "Mirobod";
        }

		public Address(string street, string houseNumber)
		{
            Country = "Uzbekistan";
            Region = "Tashkent";
            District = "Mirobod";
			Street = street;
			HouseNumber = houseNumber;
        }
     }
}