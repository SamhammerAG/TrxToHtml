namespace TrxToHtml.Models
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Times
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime creation { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime queuing { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime start { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public System.DateTime finish { get; set; }
    }
}
