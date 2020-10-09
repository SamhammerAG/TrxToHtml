using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrxToHtml
{
    public class FileScanner
    {
        private Options Options { get; }

        public FileScanner(Options options)
        {
            Options = options;
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            var directory = new DirectoryInfo(Options.WorkingDirectory);
            return directory.EnumerateFiles(Options.SearchPattern, SearchOption.AllDirectories).ToList();
        }
    }
}
