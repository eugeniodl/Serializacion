using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML
{
    public class XmlSerializerFactory : ISerializerFactory
    {
        public ISerializer CreateSerializer()
        {
            return new XmlObjectSerializer();
        }
    }
}
