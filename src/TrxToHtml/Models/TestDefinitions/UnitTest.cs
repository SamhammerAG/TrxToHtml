namespace TrxToHtml.Models.TestDefinitions
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class UnitTest
    {
        public Execution Execution { get; set; }

        public TestMethod TestMethod { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string storage { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string id { get; set; }
    }
}
