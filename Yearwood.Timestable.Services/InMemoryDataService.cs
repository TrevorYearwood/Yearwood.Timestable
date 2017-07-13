using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yearwood.Timestable.Entities;
using Yearwood.Timestable.Entities.Models;

namespace Yearwood.Timestable.Services
{
    public class InMemoryDataService : IDataService
    {
        private static readonly List<TestResult> TestResults;

        static InMemoryDataService()
        {
            TestResults = new List<TestResult>
            {
                new TestResult
                {
                    TestResultId = 1,
                    User = new ApplicationUser
                    {
                        Id = "this-is-a-test",
                        UserName = "Trevor"
                    },
                    TestResultDate = new DateTime(2017, 01, 10),
                    TotalCorrectAnswers = 100,
                    TotalNumberofQuestions = 100,
                    Percentage = 100,
                    TimeTaken = new TimeSpan(0,10,13)
                },
                new TestResult
                {
                    TestResultId = 2,
                    User = new ApplicationUser
                    {
                        Id = "this-is-a-test",
                        UserName = "Trevor"
                    },
                    TestResultDate = new DateTime(2017, 03, 10),
                    TotalCorrectAnswers = 70,
                    TotalNumberofQuestions = 80,
                    Percentage = 85,
                    TimeTaken = new TimeSpan(0,13,33)
                }
            };
        }

        public IEnumerable<TestResult> GetAll()
        {
            return TestResults;
        }

        public IEnumerable<TestResult> Get(string id)
        {
            return TestResults.Where(u => u.User.Id == id);
        }

        public void Add(TestResult newTestResult)
        {
            newTestResult.TestResultId = TestResults.Max(t => t.TestResultId) + 1;
        }

        public bool Commit()
        {
            return true;
        }
    }
}
