using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializacion
{
    public interface IRepository
    {
        void SerializarLista(List<Empresa> empresas, string rutaArchivo);
        List<Empresa> DeserializarLista(string rutaArchivo);

    }
}
