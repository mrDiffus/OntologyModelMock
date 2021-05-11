using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "asset", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Asset
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Identification Identification { get; set; }
		[XmlElement(ElementName = "administration", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Administration Administration { get; set; }
		[XmlElement(ElementName = "assetIdentificationModelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public AssetIdentificationModelRef AssetIdentificationModelRef { get; set; }
		[XmlElement(ElementName = "kind", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Kind { get; set; }
	}
}
