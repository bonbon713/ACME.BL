﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int ProductId)
        {
            Product product = new Product(ProductId);

            // temp hard coding
            if (ProductId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }


        // Save the current product
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procdure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
                
            return success;
        }
    }
}
