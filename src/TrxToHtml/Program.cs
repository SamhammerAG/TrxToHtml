using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;

namespace TrxToHtml
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run)
                .WithNotParsed(Fail);
        }

        private static void Run(Options options)
        {
            var scanner = new FileScanner(options);
            var parser = new XmlParser(options);
            var htmlBuilder = new HtmlBuilder();
            var writer = new FileWriter(options);

            var files = scanner.GetFiles().ToList();
            var testRuns = parser.GetTestRuns(files).ToList();
            var html = htmlBuilder.GetHtml(testRuns);
            writer.SaveToFile(html);
        }

        private static void Fail(IEnumerable<Error> errors)
        {
            foreach (var error in errors)
            {
                Console.Error.WriteLine(error.ToString());
            }
        }
    }
}
