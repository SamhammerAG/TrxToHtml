using CommandLine;

namespace TrxToHtml
{
    internal class Options
    {
        [Option("searchPattern", Default = "*.trx", HelpText = "search pattern to scan for trx files")]
        public string SearchPattern { get; set; } = default!;

        [Option("outputFileName", Default = "testresults.html", HelpText = "name for the html file")]
        public string OutputFilename { get; set; } = default!;

        [Option("outputDirectory", Default = ".", HelpText = "target directory for the html file")]
        public string OutputDirectory { get; set; } = default!;

        [Option("workingDirectory", Default = ".", HelpText = "directory to scan recursive for trx files")]
        public string WorkingDirectory { get; set; } = default!;
    }
}
