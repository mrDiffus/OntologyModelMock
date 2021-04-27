using System.Collections.Generic;

namespace Imf
{
    public class Model
    {
        public List<AspectModel> Submodels { get; set; }
    }

    public class AspectModel
    {
        public List<AspectObject> AspectObjects { get; set; }
    }

    public class RDLType
    {
        public string Url { get; set; }
        public string Aspect { get; set; }
    }

    public class AspectObject 
    {
        public RDLType RDLType { get; set; }
        public string Id { get; set; } // globalt unik
        public string Aspect { get; set; } // "functional" / "product" / "space"
        public AspectObject Parent { get; set; }
        public List<Relationship> Relationships { get; set; } // all relationships where this AspectObject is source
    }

    public class Relationship
    {
        public RDLType RDLType { get; set; }
        public string Id { get; set; } // globalt unikt
        public AspectObject Target { get; set; }
    }
}
