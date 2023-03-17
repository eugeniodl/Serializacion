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

        public enum IndicesTexBox
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

        public void LimpiarTextBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];
                if (miControl is TextBox)
                    miControl.Text = "";
            }
        }

        public void SetValoresTextBox(string[] valores)
        {
            if(valores.Length != CuentaTextBox)
            {
                throw new ArgumentException("Debe haber " +
                    (CuentaTextBox + 1) + " objetos string en el arreglo");
            }
            else
            {
                txtCuenta.Text = valores[(int)IndicesTexBox.CUENTA];
                txtNombre.Text = valores[(int)IndicesTexBox.NOMBRE];
                txtApellido.Text = valores[(int)IndicesTexBox.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTexBox.SALDO];
            }
        }

        public string[] GetValoresTextBox()
        {
            string[] valores = new string[CuentaTextBox];

            valores[(int)IndicesTexBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTexBox.NOMBRE] = txtNombre.Text;
            valores[(int)IndicesTexBox.APELLIDO] = txtApellido.Text;
            valores[(int)IndicesTexBox.SALDO] = txtSaldo.Text;

            return valores;
        }
    }
}
