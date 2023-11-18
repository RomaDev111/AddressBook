using Lesson11.Models;

namespace Lesson11.Services
{
    class AddressService
    {
        public Address[] Addresses { get; set; }

        public AddressService() 
        {
            Addresses = new Address[10];

            //add sample 3 data
            Addresses[0] = new Address("Amir temur", "111");
            Addresses[1] = new Address("Amir temur", "222");
            Addresses[2] = new Address("Amir temur", "333");
        }
        public void AddAddress(string address)
        {
            for (int i = 0; i < Addresses.Length; i++)
            {
                if (Addresses[i] is null)
                {
                    Addresses[i] = address;
                    break;
                }
                else if (i == Addresses.Length - 1)
                {
                    Console.WriteLine("No empty space for this address. Please, free up some memory.");
                }
                
            }
        }

        public Address[] RetriveAddresses()
        { 
            return Addresses; 
        }

    }
}