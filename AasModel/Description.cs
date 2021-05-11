using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "description", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Description
	{
		[XmlElement(ElementName = "langString", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public LangString LangString { get; set; }
	}
}
