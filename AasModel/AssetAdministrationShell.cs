using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "assetAdministrationShell", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetAdministrationShell
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Identification Identification { get; set; }
		[XmlElement(ElementName = "assetRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public AssetRef AssetRef { get; set; }

		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }

		[XmlArray("submodelRefs", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("submodelRef", typeof(SubmodelRef), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelRef> SubmodelRefs { get; set; }
	}
}
