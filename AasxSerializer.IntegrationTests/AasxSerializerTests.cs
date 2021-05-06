using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AasxSerializer.IntegrationTests
{
    public class AasxSerializerTests
    {
        [Fact]
        public async Task DeserializationOKAsync()
        {
            var aasEnv = await AasxSerializer.DeserializeFromFileAsync("aas-example.xml");
            var shortId = aasEnv.AssetAdministrationShells.First().IdShort;
            Console.WriteLine(shortId);
        }
    }
}
