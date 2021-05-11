using System.Collections.Generic;
using System.Xml.Serialization;

namespace AasModel
{
    [XmlRoot(ElementName = "submodelRef", Namespace = "http://www.admin-shell.io/aas/2/0")]
    public class SubmodelRef
	{
		[XmlArray("keys", Namespace = "http://www.admin-shell.io/aas/2/0")]
		[XmlArrayItem("key", typeof(Key), Namespace = "http://www.admin-shell.io/aas/2/0")]
		public List<Key> Keys { get; set; }
	}
}
