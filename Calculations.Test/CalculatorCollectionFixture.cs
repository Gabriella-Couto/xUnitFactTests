using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    [CollectionDefinition("Calculation")]
    public class CalculatorCollectionFixture : ICollectionFixture<CalculatorFixture>
    {

    }
}
