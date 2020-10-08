using System.Collections.Generic;
using System.Linq;
using TrxToHtml.Models;

namespace TrxToHtml
{
    public class HtmlBuilder
    {
        public string GetHtml(List<TestRun> testRuns)
        {
            // TODO generate html
            return testRuns.FirstOrDefault()?.Results.FirstOrDefault()?.testName;
        }
    }
}
