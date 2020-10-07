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
            var scanner = new Scanner(options);
            var parser = new XmlParser(options);

            var files = scanner.GetFiles().ToList();
            var testRun = parser.GetTestRuns(files).ToList();
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
