using TrxToHtml.Models.Results;
using TrxToHtml.Models.TestDefinitions;
using TrxToHtml.Models.TestEntries;
using TrxToHtml.Models.TestLists;

namespace TrxToHtml.Models
{
    [System.Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable = false)]
    public partial class TestRun
    {
        public Times Times { get; set; }

        public TestSettings.TestSettings TestSettings { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("UnitTestResult", IsNullable = false)]
        public UnitTestResult[] Results { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("UnitTest", IsNullable = false)]
        public UnitTest[] TestDefinitions { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("TestEntry", IsNullable = false)]
        public TestEntry[] TestEntries { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("TestList", IsNullable = false)]
        public TestList[] TestLists { get; set; }

        public ResultSummary.ResultSummary ResultSummary { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string id { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string runUser { get; set; }
    }
}
