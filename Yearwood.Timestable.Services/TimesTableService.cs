using System.Collections.Generic;
using System.Linq;
using Yearwood.Timestable.Common;

namespace Yearwood.Timestable.Services
{
    public class TimesTableService
    {
        public List<int> GetRandomNumbers(int highestNumberRange, int totalNumberRange)
        {
            var numberRange = Enumerable.Range(1, highestNumberRange);

            return numberRange.Shuffle().Take(totalNumberRange).ToList();
        }
    }
}