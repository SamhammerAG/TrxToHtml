namespace TrxToHtml.Models.ResultSummary
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class ResultSummary
    {
        public Counters Counters { get; set; }

        public Output Output { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public string outcome { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("RunInfo", IsNullable = false)]
        public RunInfo[] RunInfos { get; set; }
    }
}
