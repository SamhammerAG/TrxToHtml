namespace TrxToHtml.Models.TestEntries
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestEntry
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testId { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string executionId { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string testListId { get; set; }
    }
}
