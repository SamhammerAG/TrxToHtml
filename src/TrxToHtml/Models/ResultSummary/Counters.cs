namespace TrxToHtml.Models.ResultSummary
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Counters
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint total { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint executed { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint passed { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint failed { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint error { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint timeout { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint aborted { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint inconclusive { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint passedButRunAborted { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint notRunnable { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint notExecuted { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint disconnected { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint warning { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint completed { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint inProgress { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public uint pending { get; set; }
    }
}
