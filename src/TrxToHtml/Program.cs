using System;
using System.Collections.Generic;
using CommandLine;

namespace TrxToHtml
{
    public class Program
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
            var files = scanner.GetFiles();
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
