using System;
using Lesson11.Models;
using Lesson11.Services;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressService addressService = new AddressService();

            foreach (Address address in addressService.RetrieveAddresses())
            {
                if (address is null)
                {
                    break;
                }
                Console.WriteLine($"{address.Country}, {address.Region}, {address.District}, {address.Street}");
            }
        }
    }
}

 