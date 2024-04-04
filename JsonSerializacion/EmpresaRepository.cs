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
            string json = OpenFileEmpresa(rutaArchivo);
            if (json.Substring(0, 5) != "Falla ")
                return JsonConvert.DeserializeObject<List<Empresa>>(json);
            else
            {
                var listaEmpresa = new List<Empresa>();
                var empresa = new Empresa();
                empresa.Nombre = json;
                listaEmpresa.Add(empresa);
                return listaEmpresa;
            }
        }

        private string OpenFileEmpresa(string rutaArchivo)
        {
            try
            {
                string json = "";
                using (var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        json = sr.ReadToEnd();
                    }
                }
                return json;
            }
            catch (Exception ex)
            {

                return "Falla " + ex.Message;
            }
        }

        public void SerializarLista(List<Empresa> empresas, string rutaArchivo)
        {
            string json = JsonConvert.SerializeObject(empresas, Formatting.Indented);
            SaveFileEmpresa(json, rutaArchivo);
        }

        private void SaveFileEmpresa(string json, string rutaArchivo)
        {
            try
            {
                using (var fs = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(json);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Falla: {ex.Message}");
            }
        }
    }
}
