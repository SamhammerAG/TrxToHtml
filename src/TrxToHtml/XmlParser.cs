using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TrxToHtml.Models;

namespace TrxToHtml
{
    public class XmlParser
    {
        private XmlSerializer Serializer { get; }

        public XmlParser()
        {
            Serializer = new XmlSerializer(typeof(TestRun));
        }

        public IEnumerable<TestRun> GetTestRuns(List<FileInfo> files)
        {
            foreach (var file in files)
            {
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
