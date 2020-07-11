using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DesignPatterns.Prototype.CopyThroughSerialization
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, self);
                stream.Position = 0;
                var copy = (T)serializer.Deserialize(stream);
                return copy;
            }
        }

        public static T DeepCopyJson<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            var deserialized = JsonConvert.DeserializeObject<T>(serialized);
            return deserialized;
        }
    }
}