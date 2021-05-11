using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "submodelElementCollection", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelElementCollection
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
		[XmlElement(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SemanticId SemanticId { get; set; }
		[XmlElement(ElementName = "value", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Value Value { get; set; }
		[XmlElement(ElementName = "ordered", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Ordered { get; set; }
		[XmlElement(ElementName = "allowDuplicates", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string AllowDuplicates { get; set; }
	}
}
