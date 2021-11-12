using System;
using ACME.BL;
using Xunit;

namespace ACM.BL.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void FullNameValidTest()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "James",
                LastName = "Njoroge"
            };

            string expected = "James, Njoroge";

            // act
            string actual = customer.FullName;

            //assert

            Assert.Equal(expected,actual);
        }
        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "",
                LastName = "Njoroge"
            };

            string expected = "Njoroge";

            // act
            string actual = customer.FullName;

            //assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "James",
                LastName = ""
            };

            string expected = "James";

            // act
            string actual = customer.FullName;

            //assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "James",
                EmailAddress = "njorojimm@gmail.com"
            };
            var expected = true;
            // act
            var actual = customer.Validate();
            //assert
            Assert.Equal(expected, actual);
        }


    }
}
