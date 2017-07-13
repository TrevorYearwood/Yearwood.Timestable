using System;
using Microsoft.Extensions.Logging;

namespace Yearwood.Timestable.Services
{
    public class CalculationService
    {
        private readonly ILogger _logger;

        public CalculationService(ILogger<CalculationService> logger)
        {
            _logger = logger;
        }

        public decimal CalculatePercentage(decimal totalCorrectAnswers, decimal totalCountOfQuestions)
        {
            try
            {
                return totalCorrectAnswers / totalCountOfQuestions * 100;
            }
            catch (Exception e)
            {                
                _logger.LogError(new EventId(8000), e.Message);
                throw;
            }
        }
    }
}
