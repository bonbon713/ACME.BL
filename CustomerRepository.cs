using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Retrieves the definded customer
            // Temp hard-coded values to return a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        // Saves the customer
        public bool Save(Customer customer)
        {
            return true;
        }

    }
    

}
