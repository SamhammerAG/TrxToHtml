namespace TrxToHtml.Models.TestLists
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestList
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string id { get; set; }
    }
}
