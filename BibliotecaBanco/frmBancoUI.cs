using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaBanco
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTextBox = 4;

        public enum IndicesTextBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        }

        public frmBancoUI()
        {
            InitializeComponent();
        }

        public void LimpiarTexBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];
                if (miControl is TextBox)
                    miControl.Text = "";
            }
        }

        public void SetValoresTexBox(string[] valores)
        {
            if(valores.Length != CuentaTextBox)
            {
                throw (new ArgumentException("Debe haber " +
                    (CuentaTextBox + 1) + " objetos string en el arreglo"));
            }
            else
            {
                txtCuenta.Text = valores[(int)IndicesTextBox.CUENTA];
                txtPrimerNombre.Text = valores[(int)IndicesTextBox.NOMBRE];
                txtApellidoPaterno.Text = valores[(int)IndicesTextBox.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTextBox.SALDO];
            }
        }

        public string[] GetValoresTextBox()
        {
            string[] valores = new string[CuentaTextBox];

            valores[(int)IndicesTextBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTextBox.NOMBRE] = txtPrimerNombre.Text;
            valores[(int)IndicesTextBox.APELLIDO] = txtApellidoPaterno.Text;
            valores[(int)IndicesTextBox.SALDO] = txtSaldo.Text;

            return valores;
        }
    }
}
