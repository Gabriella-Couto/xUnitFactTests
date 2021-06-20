using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    public class CustomerTest 
    {
        [Fact]
        [Trait("CustomerName", "Name")]
        public void CustomerNameNotNull()
        {
            Customer customer = new Customer("Ana", 20);
            Assert.NotNull(customer.Name);
        }

        [Fact]
      
        public void CustomerObjectNotNull()
        {
            Customer customer = new Customer("Ana", 20);
            Assert.NotNull(customer);
        }

        [Fact]
        [Trait("CustomerName", "Name")]
        public void CustomerNameIsEmpty()
        {
            Customer customer = new Customer("", 20);
            Assert.Empty(customer.Name);
        }

        [Trait("CustomerAge", "Age")]
        [Fact]
        public void CustomerIsOverAge()
        {
            Customer customer = new Customer("Loki", 20);
            Assert.True(customer.Age > 18);
        }

        [Trait("CustomerAge", "Age")]
        [Fact]
        public void CustomerIsElderly()
        {
            Customer customer = new Customer("Loki", 68);
            Assert.InRange(customer.Age, 60, 100);
        }

        [Trait("CustomerAge", "Age")]
        [Fact]
        public void CustomerAgeIsInvalid()
        {
            Customer customer = new Customer("Loki", -2);
            var exception = Assert.Throws<ArgumentException>(() => customer.InvalidAge(customer.Age));
            Assert.Equal("Invalid_value", exception.Message);
        }

     
    }

}
