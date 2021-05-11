using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "value", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Value
	{
		[XmlElement(ElementName = "submodelElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelElement> SubmodelElement { get; set; }
	}
}
