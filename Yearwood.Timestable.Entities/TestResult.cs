using System;
using Yearwood.Timestable.Entities.Models;

namespace Yearwood.Timestable.Entities
{
    public class TestResult
    {
        public int TestResultId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime TestResultDate { get; set; }

        public decimal TotalCorrectAnswers { get; set; }

        public decimal TotalNumberofQuestions { get; set; }

        public decimal Percentage { get; set; }

        public TimeSpan TimeTaken { get; set; }
    }
}
