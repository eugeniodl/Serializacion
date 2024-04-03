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
            string strJson = OpenFileEmpresa(rutaArchivo);
            if (strJson.Substring(0, 5) != "Falla")
                return JsonConvert.DeserializeObject<List<Empresa>>(strJson);
            else
            {
                var lista = new List<Empresa>();
                var empresa = new Empresa();
                empresa.Nombre = strJson;
                lista.Add(empresa);
                return lista;
            }
                
        }

        private string OpenFileEmpresa(string rutaArchivo)
        {
            try
            {
                string json = "";
                using (var sr = new StreamReader(rutaArchivo))
                {
                    json = sr.ReadToEnd();
                }
                return json;
            }
            catch (Exception ex)
            {

                return "Falla: " + ex.Message;
            }
        }

        public void SerializarLista(List<Empresa> empresa, string rutaArchivo)
        {
            string strJson = JsonConvert.SerializeObject(empresa, Formatting.Indented);
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
    }
}
