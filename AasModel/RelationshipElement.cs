using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "relationshipElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class RelationshipElement
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
		[XmlElement(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SemanticId SemanticId { get; set; }
		[XmlElement(ElementName = "first", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public First First { get; set; }
		[XmlElement(ElementName = "second", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Second Second { get; set; }
		[XmlElement(ElementName = "category", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Category { get; set; }
	}
}
