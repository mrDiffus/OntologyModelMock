using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "key", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Key
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "local")]
		public bool Local { get; set; }
		[XmlAttribute(AttributeName = "idType")]
		public string IdType { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
