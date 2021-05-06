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


	[XmlRoot(ElementName = "assetRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class AssetRef
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
	}

	[XmlRoot(ElementName = "submodelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SubmodelRef
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
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

		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }

		[XmlArray("submodelRefs", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("submodelRef", typeof(SubmodelRef), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelRef> SubmodelRefs { get; set; }
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
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
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

	[XmlRoot(ElementName = "semanticId", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class SemanticId
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
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

		[XmlArray("submodelElements", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("submodelElement", typeof(SubmodelElement), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelElement> SubmodelElements { get; set; }
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

	[XmlRoot(ElementName = "first", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class First
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
	}

	[XmlRoot(ElementName = "second", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Second
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
	}

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

	[XmlRoot(ElementName = "value", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Value
	{
		[XmlElement(ElementName = "submodelElement", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<SubmodelElement> SubmodelElement { get; set; }
	}

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

	[XmlRoot(ElementName = "langString", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class LangString
	{
		[XmlAttribute(AttributeName = "lang")]
		public string Lang { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "description", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class Description
	{
		[XmlElement(ElementName = "langString", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public LangString LangString { get; set; }
	}

	[XmlRoot(ElementName = "dataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class DataSpecification
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
	}

	[XmlRoot(ElementName = "embeddedDataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
	public class EmbeddedDataSpecification
	{
		[XmlElement(ElementName = "dataSpecification", Namespace = "http://www.admin-shell.io/aas/2/0")]
		public DataSpecification DataSpecification { get; set; }
	}
}
