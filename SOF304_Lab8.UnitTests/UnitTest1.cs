using Moq;

namespace SOF304_Lab8.UnitTests
{
    public class Tests
    {
        

        [Test]
        public void ConvertUsdToVnd_GivenValidData_ReturnVNDamount()
        {
            var mock = new Mock<IConvertRate>();
            mock.Setup(item => item.UsdRate()).Returns(20);
            CurrencyConverter converter = new CurrencyConverter(mock.Object);
            double expected = 100;
            double actual = converter.ConvertUsdToVnd(5);
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}