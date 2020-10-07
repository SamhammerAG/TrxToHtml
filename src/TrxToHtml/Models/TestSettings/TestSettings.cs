namespace TrxToHtml.Models.TestSettings
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestSettings
    {
        public Deployment Deployment { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string id { get; set; }
    }
}
