using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GenericDeserializer
{
    public class XmlDeserializer<T>
    {
        private readonly XmlSerializer _serializer;

        public XmlDeserializer()
        {
            _serializer = new XmlSerializer(typeof(T));
        }

        public T Deserialize(XmlReader xmlReader)
        {
            return (T)_serializer.Deserialize(xmlReader);
        }

        public T Deserialize(TextReader textReader)
        {
            return (T)_serializer.Deserialize(textReader);
        }

        public T Deserialize(Stream stream)
        {
            return (T)_serializer.Deserialize(stream);
        }

        public T Deserialize(XmlReader xmlReader, string encodingStyle)
        {
            return (T)_serializer.Deserialize(xmlReader, encodingStyle);
        }

        public T Deserialize(XmlReader xmlReader, XmlDeserializationEvents events)
        {
            return (T)_serializer.Deserialize(xmlReader, events);
        }

        public T Deserialize(XmlReader xmlReader, string encodingStyle, XmlDeserializationEvents events)
        {
            return (T)_serializer.Deserialize(xmlReader, encodingStyle, events);
        }

    }
}