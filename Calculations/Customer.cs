using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void InvalidAge(int age)
        {
            if(age < 0  || age > 150)
            {
                throw new ArgumentException("Invalid_value");
            }
        }
    }
}
