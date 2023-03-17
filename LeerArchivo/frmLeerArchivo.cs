using BibliotecaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerArchivo
{
    public partial class frmLeerArchivo : frmBancoUI
    {
        // objeto para deserializar el Registro en formato binario
        private BinaryFormatter lector = new BinaryFormatter();
        private FileStream entrada; // flujo para leer de un archivo

        public frmLeerArchivo()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;

            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;
            LimpiarTexBox();

            if(nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                entrada = new FileStream(nombreArchivo, FileMode.Open,
                    FileAccess.Read);

                btnAbrir.Enabled = false;
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // deserializa el Registro y almacena los datos en controles TextBox
            try
            {
                // obtiene el siguiente RegistroSerializable disponible en el archivo
                RegistroSerializable registro = 
                    (RegistroSerializable)lector.Deserialize(entrada);

                // almacena los valores del Registro en un arreglo string temporal
                string[] valores = new string[]
                {
                    registro.Cuenta.ToString(),
                    registro.PrimerNombre.ToString(),
                    registro.ApellidoPaterno.ToString(),
                    registro.Saldo.ToString()
                };

                // copia los valores del arreglo string a los controles TextBox
                SetValoresTexBox(valores);
            }
            catch (SerializationException)
            {
                entrada.Close(); // cierra objeto FileStream si no hay registros en el archivo
                btnAbrir.Enabled = true; // habilita el botón Abrir archivo
                btnSiguiente.Enabled=false; // deshabilita el botón Siguiente registro

                LimpiarTexBox();

                // notifica al usuario si no hay registros en el archivo
                MessageBox.Show("No hay más registros en el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
