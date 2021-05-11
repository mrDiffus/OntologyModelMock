using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "langString", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class LangString
	{
		[XmlAttribute(AttributeName = "lang")]
		public string Lang { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
