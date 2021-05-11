using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "administration", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Administration
	{
		[XmlElement(ElementName = "version", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Version { get; set; }
		[XmlElement(ElementName = "revision", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Revision { get; set; }
	}
}
