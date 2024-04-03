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
        }

        private void btnSerializarLista_Click(object sender, EventArgs e)
        {

        }
    }
}
