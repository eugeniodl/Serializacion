using SerializacionBinaria;
using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("1) Crear y serializar registro"+
    "\n2) Leer registro");
string valor = Console.ReadLine();
int opcion = Convert.ToInt32(valor);

switch(opcion)
{
    case 1:
        // Creamos el Registro
        Console.WriteLine("Digite el número de la cuenta");
        int cuenta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escriba el primer nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Escriba el apellido paterno");
        string apellido = Console.ReadLine();
        Console.WriteLine("Digite el saldo de la cuenta");
        decimal saldo = Convert.ToDecimal(Console.ReadLine());

        RegistroSerializable registro = new RegistroSerializable(cuenta,
            nombre, apellido, saldo);

        // Empezamos la serialización
        Console.WriteLine("----- Serializamos -----");

        // seleccionamos el aplicador de formato
        BinaryFormatter aplicadorFormato = new BinaryFormatter();
        Stream salida = new FileStream("registro", FileMode.Create,
            FileAccess.Write);

        // Serializamos
        aplicadorFormato.Serialize(salida, registro);

        // Cerramos el Stream
        salida.Close();     

        break;
    case 2:
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}
