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
            var files = directory.EnumerateFiles(Options.SearchPattern, SearchOption.AllDirectories).ToList();

            if (Options.All)
            {
                return files;
            }

            return FilterByLatest(files);
        }

        public IEnumerable<FileInfo> FilterByLatest(List<FileInfo> files)
        {
            return files
                .GroupBy(f => f.Directory!.FullName)
                .Select(g => g.OrderBy(f => f.LastWriteTime).Last());
        }
    }
}
