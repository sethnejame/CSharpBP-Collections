﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        /// <summary>
        /// Retrieve all of the approved vendors (in any collection type)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC", Email = "abc@abc.com"});
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "Fake Doors", Email = "fakedoors@realfakedoors.com"});
            }

            // foreach (var vendor in vendors)
            // {
            //     Console.WriteLine(vendor);
            // }

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }

            return vendors;
        }

        ///<summary>
        /// Retrieves all approved vendors, one at time
        /// </summary>
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            // Get the data from the database (will return 'vendors')
            this.Retrieve();

            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Vendor ID: {vendor.VendorId}");
                yield return vendor;
            }
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
        
        /// <summary>
        /// Retrieves a generic value from the DB
        /// </summary>
        /// <returns></returns>
        public T RetrieveValue<T>(string sql, T defaultValue) where T : struct 
        {
            T value = defaultValue;
            return value;
        }
        
        /// <summary>
        /// Overload added to enable retrieving string (reference type) from DB
        /// </summary>
        /// <returns></returns>
        public string RetrieveValue(string sql, string defaultValue) 
        {
            string value = defaultValue;
            return value;
        }

        /// <summary>
        /// Retrieves all of the vendors
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
            {
                {new Vendor() {VendorId = 1, CompanyName = "ABC", Email = "abc@abc.com"}},
                {new Vendor() {VendorId = 2, CompanyName = "Fake Doors", Email = "fakedoors@realfakedoors.com"}},
                {new Vendor() {VendorId = 3, CompanyName = "Berni Cat Co", Email = "bernie@cat.com"}},
                {new Vendor() {VendorId = 4, CompanyName = "Cat Charlie Inc", Email = "charlie@friend.com"}},
                {new Vendor() {VendorId = 5, CompanyName = "Natalie AB", Email = "nat@wifey.com"}},
                {new Vendor() {VendorId = 6, CompanyName = "Worldfavor", Email = "seth@worldfavor.com"}},
                {new Vendor() {VendorId = 7, CompanyName = "Mondido", Email = "seth@mondido.com"}},
                {new Vendor() {VendorId = 8, CompanyName = "Acme Corp", Email = "acme@corp.com"}},
                {new Vendor() {VendorId = 9, CompanyName = "Hogwarts Magic Cat Co", Email = "magic@isfake.com"}},
                {new Vendor() {VendorId = 10, CompanyName = "Monsters Inc", Email = "monsters@arereal.com"}},

            };
            return vendors;
        }
    }
}
