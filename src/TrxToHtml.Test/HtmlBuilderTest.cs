using System.Collections.Generic;
using FluentAssertions;
using TrxToHtml.Models;
using TrxToHtml.Models.Results;
using Xunit;

namespace TrxToHtml.Test
{
    public class HtmlBuilderTest
    {
        [Fact]
        public void GetHtml_ShouldParseTestRunPlaceholders()
        {
            var textTemplate = "{{ for run in TestRuns }}{{ for result in run.Results }}{{ result.testName }};{{ end }}{{ end }}";

            var testRuns = new List<TestRun>
            {
                new TestRun
                {
                    Results = new[]
                    {
                        new UnitTestResult { testName = "test1" },
                        new UnitTestResult { testName = "test2" }
                    }
                }
            };

            var html = new HtmlBuilder(new Options()).ParseHtml(testRuns, textTemplate);

            html.Should().Be("test1;test2;");
        }
    }
}
