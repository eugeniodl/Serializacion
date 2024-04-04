using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSerializacion
{
    public partial class FrmJsonSerializacion : Form
    {
        List<Empresa> empresas = new List<Empresa>();
        public FrmJsonSerializacion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.Nombre = txtNombre.Text;
            empresa.Municipio = txtMunicipio.Text;
            empresa.Departamento = txtDepartamento.Text;

            empresas.Add(empresa);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = empresas;

            btnSerializarLista.Enabled = true;
            ClearTextBoxes();
            txtNombre.Focus();
        }

        // limpia todos los controles TextBox
        private void ClearTextBoxes()
        {
            // itera a través de cada Control en el formulario
            foreach (Control guiControl in Controls)
            {
                // si el Control es TextBox, lo limpia
                (guiControl as TextBox)?.Clear();
            }
        }

        private void btnSerializarLista_Click(object sender, EventArgs e)
        {
            // crea un cuadro de diálogo que permite al usuario guardar el archivo
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // permite al usuario crear el archivo
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // nombre del archivo en el que
                                                 // se van a guardar los datos
            }

            // se asegura de que el usuario haga clic en "Guardar"
            if (result == DialogResult.OK)
            {
                // muestra error si no obtiene el nombre del archivo especificado
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // guarda el archivo mediante el objeto EmpresaRepository
                    try
                    {
                        var empresaRepository = new EmpresaRepository();
                        empresaRepository.SerializarLista(empresas, fileName);

                        // deshabilita el botón "Serializar lista" y habilita el botón "Insertar"
                        btnSerializarLista.Enabled = false;
                        btnInsertar.Enabled = true;

                        // notifica al usuario que el archivo ha sido serializado
                        MessageBox.Show("Archivo serializado correctamente", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // notifica al usuario si el archivo existe
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeserializarLista_Click(object sender, EventArgs e)
        {
            // crea un cuadro de diálogo que permite al usuario abrir el archivo
            DialogResult result; // resultado de OpenFileDialog
            string fileName; // nombre del archivo que contiene los datos

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // obtiene el nombre de archivo
            }

            // se asegura de que el usuario haga clic en "Abrir"
            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                // muestra error si el usuario especifica un archivo inválido
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // abre el archivo mediante el objeto EmpresaRepository
                    try
                    {
                        var empresaRepository = new EmpresaRepository();
                        empresas = empresaRepository.DeserializarLista(fileName);

                        dgvDatos.DataSource = empresas;

                        btnDeserializarLista.Enabled = false; // deshabilita el botón "Deserializar lista"
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error de archivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
