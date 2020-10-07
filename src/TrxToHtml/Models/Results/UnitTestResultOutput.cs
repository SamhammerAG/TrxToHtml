namespace TrxToHtml.Models.Results
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class UnitTestResultOutput
    {
        public string StdOut { get; set; }

        public ErrorInfo ErrorInfo { get; set; }
    }
}
