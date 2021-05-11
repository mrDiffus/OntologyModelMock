using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "submodel", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Submodel
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Identification Identification { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
		[XmlElement(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SemanticId SemanticId { get; set; }
		[XmlElement(ElementName = "qualifier", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Qualifier { get; set; }

		[XmlArray("submodelElements", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("submodelElement", typeof(SubmodelElement), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelElement> SubmodelElements { get; set; }
	}
}
