using FluentAssertions;
using Xunit;

namespace TrxToHtml.Test
{
    public class ScannerTest
    {
        [Fact]
        public void Scanner_MatchesTrxFiles()
        {
            var options = new Options { WorkingDirectory = ".", SearchPattern = "*.trx" };
            var scanner = new FileScanner(options);

            var files = scanner.GetFiles();

            files
                .Should().HaveCount(1)
                .And.Contain(f => f.Name == "sample.trx");
        }
    }
}
