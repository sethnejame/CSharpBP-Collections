using System;
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
        /// Retrieve all of the approved vendors
        /// </summary>
        /// <returns></returns>
        public List<Vendor> Retrieve()
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

        public T RetrieveValue<T>(string sql, T defaultValue) where T : struct 
        {
            T value = defaultValue;
            return value;
        }
        
        public string RetrieveValue(string sql, string defaultValue) 
        {
            string value = defaultValue;
            return value;
        }
    }
}
