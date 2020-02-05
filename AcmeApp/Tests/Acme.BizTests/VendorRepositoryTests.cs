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
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            // Arrange
             var repository = new VendorRepository();
                        var expected = new List<Vendor>();
                        expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC", Email = "abc@abc.com"});
                        expected.Add(new Vendor() { VendorId = 2, CompanyName = "Fake Doors", Email = "fakedoors@realfakedoors.com"});
                        
            // Act
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var vendor in vendorIterator)
            {
                Console.WriteLine(vendor);
            }

            var actual = vendorIterator.ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void RetrieveAllTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>
            {
                {new Vendor() {VendorId = 3, CompanyName = "Berni Cat Co", Email = "bernie@cat.com"}},
                {new Vendor() {VendorId = 4, CompanyName = "Cat Charlie Inc", Email = "charlie@friend.com"}},
                {new Vendor() {VendorId = 9, CompanyName = "Hogwarts Magic Cat Co", Email = "magic@isfake.com"}},
            };
                        
            // Act
            var vendors = repository.RetrieveAll();

            // var vendorQuery = from v in vendors
            //     where v.CompanyName.Contains("Cat")
            //     select v;

            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("Cat"))
                .OrderBy(v => v.CompanyName);
            
            // Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }
    }
}