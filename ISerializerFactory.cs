using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    // Interfaz de la factory de serialización
    public interface ISerializerFactory
    {
        ISerializer CreateSerializer();
    }
}
