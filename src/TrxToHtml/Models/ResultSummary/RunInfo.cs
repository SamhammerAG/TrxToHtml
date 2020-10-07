namespace TrxToHtml.Models.ResultSummary
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class RunInfo
    {
        public string Text { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string computerName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string outcome { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime timestamp { get; set; }
    }
}
