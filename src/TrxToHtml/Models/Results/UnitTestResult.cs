namespace TrxToHtml.Models.Results
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class UnitTestResult
    {
        public UnitTestResultOutput Output { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string executionId { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testId { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string computerName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string duration { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime startTime { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime endTime { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testType { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string outcome { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testListId { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string relativeResultsDirectory { get; set; }
    }
}
