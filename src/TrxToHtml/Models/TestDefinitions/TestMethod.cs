namespace TrxToHtml.Models.TestDefinitions
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestMethod
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string codeBase { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string adapterTypeName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string className { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string name { get; set; }
    }
}
