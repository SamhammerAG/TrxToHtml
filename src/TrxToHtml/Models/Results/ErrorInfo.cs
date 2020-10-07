namespace TrxToHtml.Models.Results
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class ErrorInfo
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }
    }
}
