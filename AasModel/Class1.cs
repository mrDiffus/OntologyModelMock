using System;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aas
{

    [XmlRoot("aas:aasenv")]
    public class Aasenv {
        [XmlElement("aas:assetAdministrationShells")]
        public List<AssetAdministrationShells> AssetAdministrationShells { get; set; }
        [XmlElement("aas:assets")]
        public List<Asset> Assets { get; set; }

    }

    public class AssetAdministrationShells
    {
        [XmlElement("aas:idShort")]
        public string  IdShort { get; set; }
        [XmlElement("aas:assetRef")]
        public List<Key> assetRef { get; set; }
        [XmlElement("aas:submodelRefs")]
        public List<Key> submodelRefs { get; set; }

    }
    public class Key {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("idType")]
        public string IdType { get; set; }
        [XmlAttribute("local")]
        public bool Local { get; set; }
    }

    public class Asset {
        [XmlElement("idShort")]
        public string IdShort { get; set; }
        [XmlElement("identification")]
        public string Identification { get; set; }
        [XmlElement("kind")]
        public string Kind { get; set; }
        [XmlElement("semanticId")]
        public List<Key> keys { get; set; }

    }

}
