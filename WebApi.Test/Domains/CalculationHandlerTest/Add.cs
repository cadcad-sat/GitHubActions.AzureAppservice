using WebApi.Domains;
using Xunit;

namespace WebApi.Test.Domains.CalculationHandlerTest
{
    public class Add
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        public void Ok(int a, int b, int r)
        {
            var handler = new CalculationHandler();
            var result = handler.Add(a, b);
            Assert.True(result == r);
        }
    }
}
