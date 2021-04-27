using AasModel;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AasxSerializer
{
    public static class AasxSerializer
    {
        public static async Task<AasEnv> DeserializeFromFileAsync(string filename)
        {
            var content = "";
            using (var reader = File.OpenText(filename))
            {
                content = await reader.ReadToEndAsync();
            }
            return Deserialize(content);
        }

        public static AasEnv Deserialize(string xml)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                return (AasEnv)new XmlSerializer(typeof(AasEnv)).Deserialize(stream);
            }
        }

        public static string Serialize(AasEnv xml)
        {
            throw new NotImplementedException();
        }
    }
}
