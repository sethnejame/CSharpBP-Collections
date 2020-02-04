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
        /// Retrieves all approved vendors (in array) from DB
        /// </summary>
        /// <returns></returns>
        public Vendor[] RetrieveArray()
        {
            var vendors = new Vendor[2]
            {
                new Vendor()
                    {VendorId = 42, Email = "bernie@cat.com", CompanyName = "Cat Company"},
                new Vendor()
                    {VendorId = 33, Email = "natalie@nejame.com", CompanyName = "NeJame & Co"}
            };
            return vendors;
        }

        /// <summary>
        /// Retrieve all of the approved vendors (in a List of type Vendor)
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
        /// Retrieves all approved vendors (as a dictionary) 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            #region Dictionary w/ Iteration and Access Methods
            var vendors = new Dictionary<string, Vendor>()
            {
                {
                    "Acme Corp", new Vendor()
                        {VendorId = 1, CompanyName = "Acme Corporation", Email = "acme@acorp.com"}
                },
                {
                    "XYZ Inc", new Vendor()
                        {VendorId = 2, CompanyName = "Xylophone Corp", Email = "ringaling@ding.com"}
                }
            };

            foreach (var element in vendors)
            {
                Console.WriteLine("Key: " + element.Key + "," + "Value: " + element.Value);
            }

            // foreach (var vendorsValue in vendors.Values)
            // {
            //     Console.WriteLine(vendorsValue);
            // }
            //
            // foreach (var companyName in vendors.Keys)
            // {
            //     Console.Write(companyName);
            // }
            //
            // Console.WriteLine(vendors["XYZ Inc"]);
            //
            // if (vendors.ContainsKey("Acme Corp"))
            // {
            //     Console.WriteLine(vendors["Acme Corp"]);
            // }
            //
            // Vendor vendor;
            // if (vendors.TryGetValue("Acme Corp", out vendor))
            // {
            //     Console.WriteLine(vendor);
            // }
            #endregion
            
            return vendors;
            
        }
    }
}
