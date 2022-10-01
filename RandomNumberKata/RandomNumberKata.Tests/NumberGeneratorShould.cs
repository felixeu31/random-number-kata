using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace RandomNumberKata.Tests
{
    public class NumberGeneratorShould
    {
        [Fact]
        public void test()
        {
            INumberGenerator numberGenerator = NumberGenerator.New();

            var generatedNumber = numberGenerator.GenerateNumber();

            generatedNumber.Should().BeGreaterThanOrEqualTo(0);
            generatedNumber.Should().BeLessThanOrEqualTo(10);
        }
    }
}
