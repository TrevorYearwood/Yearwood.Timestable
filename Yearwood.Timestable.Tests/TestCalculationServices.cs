using NUnit.Framework;
using NUnit.Framework.Internal;
using Yearwood.Timestable.Services;

namespace Yearwood.Timestable.Tests
{
    [TestFixture]
    public class TestTimesTableServices
    {
        [Test]
        public void ShouldReturnRandomNumbers()
        {
            //Arrange
            var timesTableService = new TimesTableService();
            var highestNumberRange = 11;
            var totalNumberRange = 10;

            //Act
            var result = timesTableService.GetRandomNumbers(highestNumberRange, totalNumberRange);

            //Assert
            Assert.That(result.Count, Is.EqualTo(totalNumberRange));
        }
    }
}
