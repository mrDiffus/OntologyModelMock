using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Identification
	{
		[XmlAttribute(AttributeName = "idType")]
		public string IdType { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
