using System;
using System.Collections.Generic;
using System.Text;
using Yearwood.Timestable.Entities;

namespace Yearwood.Timestable.Services
{
    public interface IDataService
    {
        IEnumerable<TestResult> GetAll();

        IEnumerable<TestResult> Get(string id);
        void Add(TestResult newTestResult);

        bool Commit();
    }
}
