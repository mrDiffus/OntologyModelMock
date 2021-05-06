using Xunit;
using System.Collections.Generic;
using AasModel;

using System.Linq;
using AasImfMapping;
using Imf;

namespace Tests
{
    public class MappingTests
    {
        //"A submodel that has a semantic ID of type 'AspectModel', is mapped to an AspectModel"
        [Fact]
        public void AAS_Submodel_SerializedToAspectObject()
        {
            var aasEnvironment = new AasEnv();
            //var shell = aasEnvironment.AssetAdministrationShells.Elements.First( shell => shell.IdShort == "shellGlobalId");
            var submodel = aasEnvironment.Submodels.First(s => s.Identification.Text == "aspectModelSemanticId");

            var aspectModel = AasImfMapper.ToAspectModel(submodel);
            var aspectObjects = aspectModel.AspectObjects;
            var locationObject = aspectObjects.First(a => a.Id == "aspectObjectGlobalId");

            Assert.Equal("locationTypeUrl", locationObject.RDLType.Url);

            Assert.Equal(locationObject.RDLType.Aspect, locationObject.Aspect);
            
        }

        [Fact]
        public void AAS_Multiple_Submodel_Builds_Tree()
        {
            var aasEnvironment = new AasEnv();
            var shell = aasEnvironment.AssetAdministrationShells.First(shell => shell.IdShort == "shellGlobalId");
            var submodels = aasEnvironment.Submodels.Where(s => s.Identification.Text == "aspectModelSemanticId").Take(2);

            var aspectModels = new List<AspectModel>();
            foreach(var submodel in submodels)
            {
                var aspectModel = AasImfMapper.ToAspectModel(submodel);
                aspectModels.Add(aspectModel);
            }

            var mergedModel = ImfMerger.Merge(aspectModels); // params AspectModels[] models

            Assert.Equal(
                mergedModel.AspectObjects.First(a => a.Id == "childId").Parent, 
                mergedModel.AspectObjects.First(a => a.Id == "parentId"));
        }

    }
}
