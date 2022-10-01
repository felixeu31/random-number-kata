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
