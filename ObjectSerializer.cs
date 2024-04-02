using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML
{
    public class ObjectSerializer
    {
        private readonly ISerializerFactory _factory;

        public ObjectSerializer(ISerializerFactory factory)
        {
            _factory = factory;
        }

        public void Serialize<T>(T obj, string fileName)
        {
            ISerializer serializer = _factory.CreateSerializer();
            serializer.Serialize(obj, fileName);
        }

        public T Deserialize<T>(string fileName)
        {
            ISerializer serializer = _factory.CreateSerializer();
            return serializer.Deserialize<T>(fileName);
        }
    }
}
