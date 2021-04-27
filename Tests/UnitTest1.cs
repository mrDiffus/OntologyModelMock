using System;
using Xunit;
using System.Collections.Generic;

namespace Tests
{
    public class UnitTest1
    {
        private IMFResolver Resolver { get; set; }
        //"A submodel that has a semantic ID of type 'AspectModel', is mapped to an AspectModel"
        [Fact]
        public void AAS_Submodel_SerializedToAspectObject()
        {
            var aasEnvironment = new AAS.Environment();
            var shell = aasEnvironment.GetShell("shellGlobalId");
            var submodel = shell.GetSubmodels("aspectModelSemanticId").First();

            var aspectModel = Resolver.ToAspectModel(submodel);
            var aspectObjects = aspectModel.AspectObjects;
            var locationObject = aspectObjects.First(a => a.Id == "aspectObjectGlobalId");

            Assert.Equal("locationTypeUrl", locationObject.Type.Url);

            locationObject.Type;
            Assert.Equal(locationObject.Type.Aspect, locationObject.Aspect);
            
        }

        [Fact]
        public void AAS_Multiple_Submodel_Builds_Tree()
        {
            var aasEnvironment = new AAS.Environment();
            var shell = aasEnvironment.GetShell("shellGlobalId");
            var submodels = shell.GetSubmodels("aspectModelSemanticId").Take(2);

            List<AspectModel> aspectModels = new List<AspectModel>();
            foreach(var submodel in submodels)
            {
                var aspectModel = Resolver.ToAspectModel(submodel);
                aspectModels.Add(aspectModel);
            }

            var mergedModel = AspectModel.Merge(aspectModels.ToArray()); // params AspectModels[] models

            Assert.Equal(
                mergedModel.AspectObjects.First(a => a.Id == "childId").Parent, 
                mergedModel.AspectObjects.First(a => a.Id == "parentId"));
        }

    }
}
