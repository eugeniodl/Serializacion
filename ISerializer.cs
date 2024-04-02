using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    // Interfaz para la serialización
    public interface ISerializer
    {
        void Serialize<T>(T obj, string fileName);
        T Deserialize<T>(string fileName);
    }
}
