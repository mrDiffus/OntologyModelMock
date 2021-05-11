using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "property", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Property
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
		[XmlElement(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SemanticId SemanticId { get; set; }
		[XmlElement(ElementName = "valueType", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string ValueType { get; set; }
		[XmlElement(ElementName = "value", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Value { get; set; }
		[XmlElement(ElementName = "category", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Category { get; set; }
	}
}
