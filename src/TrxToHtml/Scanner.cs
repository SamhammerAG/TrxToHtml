using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrxToHtml
{
    public class Scanner
    {
        private Options Options { get; }

        public Scanner(Options options)
        {
            Options = options;
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            var directory = new DirectoryInfo(Options.WorkingDirectory);
            var files = directory.EnumerateFiles(Options.SearchPattern, SearchOption.AllDirectories).ToList();

            if (Options.Verbose)
            {
                Console.WriteLine("scanner matched {0} files.", files.Count);
                files.ForEach(Console.WriteLine);
            }

            return files;
        }
    }
}
