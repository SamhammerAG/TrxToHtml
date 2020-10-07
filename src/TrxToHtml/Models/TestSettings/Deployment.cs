namespace TrxToHtml.Models.TestSettings
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Deployment
    {
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string runDeploymentRoot { get; set; }
    }
}
