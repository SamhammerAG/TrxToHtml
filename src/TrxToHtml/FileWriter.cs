using System;
using System.IO;
using System.Text;

namespace TrxToHtml
{
    public class FileWriter
    {
        public Options Options { get; }

        public FileWriter(Options options)
        {
            Options = options;
        }

        public void SaveToFile(string html)
        {
            var dirPath = Path.GetFullPath(Options.OutputDirectory, Directory.GetCurrentDirectory());
            var filePath = Path.Combine(dirPath, Options.OutputFilename);

            if (Options.Verbose)
            {
                Console.WriteLine("writing report file to {0}", filePath);
            }

            File.WriteAllText(filePath, html, Encoding.UTF8);
        }
    }
}
