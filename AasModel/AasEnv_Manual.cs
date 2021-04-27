using System;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aas_DoNotUseMe
{

    [XmlRoot("aas:aasenv")]
    public class AasEnv_Manual {
        [XmlElement("aas:assetAdministrationShells")]
        public AssetAdministrationShells AssetAdministrationShells { get; set; }

        [XmlElement("aas:assets")]
        public Assets Assets { get; set; }

        [XmlElement("aas:submodels")]
        public Submodels Submodels { get; set; }

    }

    // Shells

    public class AssetAdministrationShells
    {
        [XmlElement("aas:assetAdministrationShell")]
        public List<AssetAdministrationShell> AssetAdministrationShellElements{get; set;}
    }

    public class AssetAdministrationShell
    {
        [XmlElement("aas:idShort")]
        public string IdShort { get; set; }
        [XmlElement("aas:identifcation")]
        public Identification Identification { get; set; } 
        [XmlElement("aas:assetRef")]
        public List<Key> AssetRef { get; set; }
        [XmlElement("aas:submodelRefs")]
        public List<Key> SubmodelRefs { get; set; }
    }

    public class Identification
    {
        [XmlAttribute("idType")]
        public string idType { get; set; }
    }

    // Assets
    public class Assets
    {
        [XmlElement("aas:assets")]
        public List<Asset> AssetElements { get; set; }
    }

    public class Asset
    {
        [XmlElement("idShort")]
        public string IdShort { get; set; }
        [XmlElement("identification")]
        public string Identification { get; set; }
        [XmlElement("kind")]
        public string Kind { get; set; }
        [XmlElement("semanticId")]
        public List<Key> keys { get; set; }

    }

    // Submodels

    public class Submodels
    {
        [XmlElement("aas:submodels")]
        public List<Submodel> SubmodelElements { get; set; }
    }

    public class Submodel
    {

    }

    // Common

    public class Keys
    {
        [XmlElement("aas:keys")]
        public List<Key> KeyElements { get; set; }
    }

    public class Key {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("idType")]
        public string IdType { get; set; }
        [XmlAttribute("local")]
        public bool Local { get; set; }
        
        [XmlText]
        public string Content { get; set; }
    }



}
