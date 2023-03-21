using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionBinaria
{
    [Serializable]
    public class RegistroSerializable
    {
        private int cuenta;
        private string nombre;
        private string apellido;
        private decimal saldo;

        public RegistroSerializable() : this(0, "", "", 0.0M)
        {

        }

        public RegistroSerializable(int valorCuenta, string valorNombre,
            string valorApellido, decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            Nombre = valorNombre;
            Apellido = valorApellido;
            Saldo = valorSaldo;
        }

        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            return "Cuenta: " + Cuenta + "\n" +
                "Nombre: " + Nombre + "\n" +
                "Apellido: " + Apellido + "\n" +
                "Saldo: " + Saldo + "\n";
        }
    }
}
