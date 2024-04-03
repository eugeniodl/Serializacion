using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class JsonSerializerFactory : ISerializerFactory
    {
        public ISerializer CreateSerializer()
        {
            return new JsonSerializer();
        }
    }
}
