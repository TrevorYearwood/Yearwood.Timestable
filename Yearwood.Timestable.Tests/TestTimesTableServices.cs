using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Yearwood.Timestable.Services;
using Microsoft.Extensions.Logging;

namespace Yearwood.Timestable.Tests
{
    public class TestCalculationServices
    {
        private readonly ILogger<CalculationService> _logger;

        public TestCalculationServices(ILogger<CalculationService> logger)
        {
            _logger = logger;
        }

        private static IEnumerable<TestCaseData> CalculationValues()
        {
            yield return new TestCaseData(100, 100, 100m);
            yield return new TestCaseData(0, 100, 0m);
            yield return new TestCaseData(21, 20, 105m);
            yield return new TestCaseData(-50, 50, -100m);
            yield return new TestCaseData(10, 100, 10m);
            yield return new TestCaseData(25, 50, 50m);
        }

        [Test, TestCaseSource(nameof(CalculationValues))]
        public void ShouldReturnCorrectPercentageCalculation(int correctAnswers, int totalQuestions, decimal percentage)
        {
            //Arrange
            var calculationService = new CalculationService(_logger);

            //Act
            var result = calculationService.CalculatePercentage(correctAnswers, totalQuestions);

            //Assert
            Assert.That(result, Is.EqualTo(percentage));
        }
    }
}
