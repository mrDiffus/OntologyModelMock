using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "embeddedDataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class EmbeddedDataSpecification
	{
		[XmlElement(ElementName = "dataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public DataSpecification DataSpecification { get; set; }
	}
}
