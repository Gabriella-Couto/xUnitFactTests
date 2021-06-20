using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    public class NameTestFixture
    {
        public Name name = new Name();
    }

    public class NameTest : IClassFixture<NameTestFixture>
    {
        private readonly Name _name;

        public NameTest(NameTestFixture namesFixture)
        {
            _name = namesFixture.name;
        }

        [Fact]
        public void BuildFullnameTest()
        {
            string methodResult = _name.BuildFullname("Andressa", "Lopes");
            Assert.Equal("Andressa Lopes", methodResult);

        }

        [Fact]
        public void FullnameNotNullTest()
        {
            string methodResult = _name.BuildFullname("Andressa", "Lopes");
            Assert.NotNull(methodResult);

        }

        [Fact]
        public void FullnameNotEmptyTest()
        {
            string methodResult = _name.BuildFullname("Andressa", "Lopes");
            Assert.NotEmpty(methodResult);

        }
    }
}
