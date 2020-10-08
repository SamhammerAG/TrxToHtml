using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TrxToHtml.Models;

namespace TrxToHtml
{
    public class XmlParser
    {
        private Options Options { get; }

        private XmlSerializer Serializer { get; }

        public XmlParser(Options options)
        {
            Options = options;
            Serializer = new XmlSerializer(typeof(TestRun));
        }

        public IEnumerable<TestRun> GetTestRuns(List<FileInfo> files)
        {
            if (Options.Verbose)
            {
                Console.WriteLine("trx parsing {0} files...", files.Count);
            }

            foreach (var file in files)
            {
                if (Options.Verbose)
                {
                    Console.WriteLine(file);
                }

                yield return GetTestResult(file);
            }
        }

        public TestRun GetTestResult(FileInfo file)
        {
            using var fs = file.OpenRead();
            return Serializer.Deserialize(fs) as TestRun;
        }
    }
}
