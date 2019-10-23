﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class AddressRepository
    {
        // Retrieve one address
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            // temp hard coded
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
                {
                AddressType = 2,
                StreetLine1 = "GreenDragon",
                StreetLine2 = "Bywater",
                City = "Shire",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
                };

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
