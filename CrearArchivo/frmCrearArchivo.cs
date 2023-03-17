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

namespace CrearArchivo
{
    public partial class frmCrearArchivo : frmBancoUI
    {
        // objeto para serializar Registros en formato binario
        private BinaryFormatter aplicadorFormato = new BinaryFormatter();
        private FileStream salida; // mantiene la conexión con el archivo

        public frmCrearArchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if(resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            if(nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate,
                        FileAccess.Write);

                    btnGuardar.Enabled = false;
                    btnIntroducir.Enabled = true;
                }
                catch(IOException)
                {
                    MessageBox.Show("Error al abrir el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            string[] valores = GetValoresTextBox();

            // Registro que contiene los valores de los controles TextBox a serializar
            RegistroSerializable registro = new RegistroSerializable();

            // determina si el campo del control TextBox de la cuenta está vacío
            if(valores[(int)IndicesTextBox.CUENTA] != "")
            {
                try
                {
                    int numeroCuenta = int.Parse(valores[(int)IndicesTextBox.CUENTA]);

                    if(numeroCuenta > 0)
                    {
                        registro.Cuenta = numeroCuenta;
                        registro.Nombre = valores[(int)IndicesTextBox.NOMBRE];
                        registro.Apellido = valores[(int)IndicesTextBox.APELLIDO];
                        registro.Saldo = decimal.Parse(valores[(int)IndicesTextBox.SALDO]);

                        // escribe Registro al objeto FileStream (serializa el objeto)
                        aplicadorFormato.Serialize(salida, registro);
                    }
                    else
                    {
                        MessageBox.Show("Número de cuenta inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error al escribir en archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Formato inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarTextBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(salida != null)
            {
                try
                {
                    salida.Close();
                }
                catch(IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
