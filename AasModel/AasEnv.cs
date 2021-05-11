using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "aasenv", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AasEnv
	{
		[XmlArray("assetAdministrationShells", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("assetAdministrationShell", typeof(AssetAdministrationShell), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<AssetAdministrationShell> AssetAdministrationShells { get; set; }

		[XmlArray("assets", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("asset", typeof(Asset), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Asset> Assets { get; set; }

		[XmlArray("submodels", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("submodel", typeof(Submodel), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Submodel> Submodels { get; set; }

		[XmlElement(ElementName = "conceptDescriptions", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string ConceptDescriptions { get; set; }

		[XmlAttribute(AttributeName = "IEC", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string IEC { get; set; }

		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }

		[XmlAttribute(AttributeName = "abac", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Abac { get; set; }

		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }

		[XmlAttribute(AttributeName = "aas", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Aas { get; set; }
	}
}
