using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "entity", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Entity
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "category", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Category { get; set; }
		[XmlElement(ElementName = "description", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Description Description { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
		[XmlElement(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SemanticId SemanticId { get; set; }
		[XmlElement(ElementName = "qualifier", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Qualifier { get; set; }
		[XmlElement(ElementName = "embeddedDataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public EmbeddedDataSpecification EmbeddedDataSpecification { get; set; }
		[XmlElement(ElementName = "statements", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Statements { get; set; }
		[XmlElement(ElementName = "entityType", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string EntityType { get; set; }
		[XmlElement(ElementName = "assetRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public AssetRef AssetRef { get; set; }
	}
}
