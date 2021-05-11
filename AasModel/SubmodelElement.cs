using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "submodelElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
    public class SubmodelElement
	{
		[XmlElement(ElementName = "entity", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Entity Entity { get; set; }

		[XmlElement(ElementName = "relationshipElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public RelationshipElement RelationshipElement { get; set; }

		[XmlElement(ElementName = "submodelElementCollection", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SubmodelElementCollection SubmodelElementCollection { get; set; }

	}
}
