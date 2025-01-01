using Carglass.Service;

namespace Carglass.Tests
{
    public class NumberServiceTests
    {
        private readonly NumberService _service;

        public NumberServiceTests()
        {
            _service = new NumberService();
        }

        [Fact]
        public void TestGetDivisors()
        {
            var result = _service.GetDivisors(12);
            Assert.Equal(new List<int> { 1, 2, 3, 4, 6, 12 }, result);
        }

        [Fact]
        public void TestGetPrimeDivisors()
        {
            var divisors = new List<int> { 1, 2, 3, 4, 6, 12 };
            var result = _service.GetPrimeDivisors(divisors);
            Assert.Equal([2, 3], result);
        }
    }
}