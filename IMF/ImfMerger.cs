using System;
using System.Collections.Generic;
using System.Linq;

namespace Imf
{
    public class ImfMerger
    {
        public static AspectModel Merge(List<AspectModel> models)
        {
            return new AspectModel()
            {
                AspectObjects = models
                    .SelectMany(m => m.AspectObjects)
                    .GroupBy(ao => ao.Id)
                    .Select(g => new AspectObject
                    {
                        Id = g.Key,
                        Aspect = g.First().Aspect,
                        RDLType = g.First().RDLType,
                        Relationships = g
                            .SelectMany(ao => MergeRelationships(ao.Relationships))
                            .ToList()
                    })
                    .ToList()
            };
        }


        private static List<Relationship> MergeRelationships(List<Relationship> relationships)
        {
            return relationships
                .GroupBy(r => r.Id)
                .Select(g => new Relationship
                {
                    Id = g.Key,
                    Target = g.First().Target,
                    RDLType = g.First().RDLType
                })
                .ToList();
        }
    }
}
