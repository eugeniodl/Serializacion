using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    [Serializable]
    public class Persona
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set;}
        public string PrimerApellido { get; set;}
        public string SegundoApellido{ get; set;}
        public int Edad { get; set;}

    }
}
