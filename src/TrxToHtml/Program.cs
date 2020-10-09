using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using CommandLine.Text;

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
            Console.WriteLine(HeadingInfo.Default);
            Console.WriteLine(CopyrightInfo.Default);
            Console.WriteLine();

            var scanner = new FileScanner(options);
            var parser = new XmlParser();
            var htmlBuilder = new HtmlBuilder(options);
            var writer = new FileWriter(options);

            var files = scanner.GetFiles().ToList();
            
            if (files.Count == 0)
            {
                Console.WriteLine("No trx files found.\n");
                return;
            }

            Console.WriteLine("Processing trx files:\n");
            files.ForEach(f => Console.WriteLine($"   {f}"));

            var testRuns = parser.GetTestRuns(files).ToList();
            var html = htmlBuilder.GetHtml(testRuns);
            var htmlReportPath = writer.SaveToFile(html);

            Console.WriteLine("\nGenerated html report:\n\n   {0}", htmlReportPath);
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
