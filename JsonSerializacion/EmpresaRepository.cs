using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializacion
{
    public class EmpresaRepository : IRepository
    {
        public List<Empresa> DeserializarLista(string rutaArchivo)
        {
            var strJSON = OpenFileEmpresa(rutaArchivo);
            if (strJSON.Substring(0, 5) != "Falla")
            {
                return JsonConvert.DeserializeObject<List<Empresa>>(strJSON);
            }
            else
            {
                var lista = new List<Empresa>();
                var empresa = new Empresa();
                empresa.Nombre = strJSON;
                lista.Add(empresa);
                empresa.Nombre = strJSON;
                return lista;
            }
        }

        public void SerializarLista(List<Empresa> empresas, string rutaArchivo)
        {
            var strJson = JsonConvert.SerializeObject(empresas, Formatting.Indented);
            SaveFileEmpresa(strJson, rutaArchivo);
        }

        private void SaveFileEmpresa(string strJson, string rutaArchivo)
        {
            try
            {
                using (var sw = new StreamWriter(rutaArchivo))
                {
                    sw.WriteLine(strJson);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Falla: " + ex.Message);
            }
        }

        private string OpenFileEmpresa(string rutaArchivo)
        {
            try
            {
                var strJSON = "";
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    strJSON = sr.ReadToEnd();
                }
                return strJSON;
            }
            catch (Exception ex)
            {

                return "Falla: " + ex.Message;
            }
        }
    }
}
