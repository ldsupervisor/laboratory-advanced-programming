using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization
{
    public static class FileTransformer
    {
        public static void SerializeToXml<T>(T data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(fs, data);
        }

        public static T? DeserializeFromXml<T>(string filePath) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using FileStream fs = new FileStream(filePath, FileMode.Open);
            return serializer.Deserialize(fs) as T;
        }

        public static void SerializeToJson<T>(T data, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, json);
        }

        public static T? DeserializeFromJson<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
