using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 42;
            
            //Act
            var actual = repository.RetrieveValue<int>("poop", 42);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void RetrieveStringValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = "sandwich";
            
            //Act
            var actual = repository.RetrieveValue("poop", "sandwich");
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();
            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC", Email = "abc@abc.com"});
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "Fake Doors", Email = "fakedoors@realfakedoors.com"});
            
            //Act
            var actual = repository.Retrieve();
            
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
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
            
            //Act
            var actual = repository.RetrieveWithKeys();
            
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}