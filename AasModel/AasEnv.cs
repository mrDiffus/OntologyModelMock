using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
	[XmlRoot(ElementName = "aasenv", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AasEnv
	{
		[XmlElement(ElementName = "assetAdministrationShells", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public AssetAdministrationShells AssetAdministrationShells { get; set; }
		[XmlElement(ElementName = "assets", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Assets Assets { get; set; }
		[XmlElement(ElementName = "submodels", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Submodels Submodels { get; set; }
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

	[XmlRoot(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Identification
	{
		[XmlAttribute(AttributeName = "idType")]
		public string IdType { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "key", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Key
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "local")]
		public bool Local { get; set; }
		[XmlAttribute(AttributeName = "idType")]
		public string IdType { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Keys
	{
		[XmlElement(ElementName = "key", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Elements { get; set; }
	}

	[XmlRoot(ElementName = "assetRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetRef
	{
		[XmlElement(ElementName = "keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Keys Keys { get; set; }
	}

	[XmlRoot(ElementName = "submodelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelRef
	{
		[XmlElement(ElementName = "keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Keys Keys { get; set; }
	}

	[XmlRoot(ElementName = "submodelRefs", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelRefs
	{
		[XmlElement(ElementName = "submodelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelRef> SubmodelRef { get; set; }
	}

	[XmlRoot(ElementName = "assetAdministrationShell", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetAdministrationShell
	{
		[XmlElement(ElementName = "idShort", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string IdShort { get; set; }
		[XmlElement(ElementName = "identification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Identification Identification { get; set; }
		[XmlElement(ElementName = "assetRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public AssetRef AssetRef { get; set; }
		[XmlElement(ElementName = "submodelRefs", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SubmodelRefs SubmodelRefs { get; set; }
	}

	[XmlRoot(ElementName = "assetAdministrationShells", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetAdministrationShells
	{
		[XmlElement(ElementName = "assetAdministrationShell", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<AssetAdministrationShell> Elements { get; set; }
	}

	[XmlRoot(ElementName = "administration", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Administration
	{
		[XmlElement(ElementName = "version", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Version { get; set; }
		[XmlElement(ElementName = "revision", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public string Revision { get; set; }
	}

	[XmlRoot(ElementName = "assetIdentificationModelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetIdentificationModelRef
	{
		[XmlElement(ElementName = "keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Keys Keys { get; set; }
	}

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

	[XmlRoot(ElementName = "assets", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Assets
	{
		[XmlElement(ElementName = "asset", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Asset> Elements { get; set; }
	}

	[XmlRoot(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SemanticId
	{
		[XmlElement(ElementName = "keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Keys Keys { get; set; }
	}

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
		[XmlElement(ElementName = "submodelElements", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public SubmodelElements SubmodelElements { get; set; }
	}

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

	[XmlRoot(ElementName = "submodelElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelElement
	{
		[XmlElement(ElementName = "property", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public Property Property { get; set; }
	}

	[XmlRoot(ElementName = "submodelElements", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelElements
	{
		[XmlElement(ElementName = "submodelElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelElement> SubmodelElement { get; set; }
	}

	[XmlRoot(ElementName = "submodels", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Submodels
	{
		[XmlElement(ElementName = "submodel", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Submodel> Elements { get; set; }
	}
}
