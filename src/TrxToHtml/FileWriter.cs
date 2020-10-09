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

        public string SaveToFile(string html)
        {
            var dirPath = Path.GetFullPath(Options.OutputDirectory, Directory.GetCurrentDirectory());
            var filePath = Path.Combine(dirPath, Options.OutputFilename);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            File.WriteAllText(filePath, html, Encoding.UTF8);
            return filePath;
        }
    }
}
