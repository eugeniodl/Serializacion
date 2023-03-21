using SerializacionBinaria;
using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("Serialización Binaria en C#\r");
Console.WriteLine("---------------------------\n");

BinaryFormatter formateador = new BinaryFormatter();
Stream miStream = null;
RegistroSerializable registro = null;
int cuenta = 0;
string valorCuenta = "";
string nombre = "";
string apellido = "";
decimal saldo = 0.0M;
string valorSaldo = "";

// Solicite al usuario que elija una opción
Console.WriteLine("Elija una opción de la siguiente lista:");
Console.WriteLine("\ts - Crear y serializar registro");
Console.WriteLine("\td - Deserializar registro");
Console.Write("¿Su opción? ");

string op = Console.ReadLine()!;

switch (op)
{
    case "s":
        // se crea el Stream
        miStream = new FileStream("clientes.txt", FileMode.OpenOrCreate, FileAccess.Write);

        // Creamos el objeto registro

        // Solicite al usuario que escriba el número de la cuenta.
        Console.Write("Escriba el número de la cuenta y luego presione Enter: ");
        valorCuenta = Console.ReadLine()!;

        while (!int.TryParse(valorCuenta, out cuenta))
        {
            Console.Write("Esta no es una entrada válida. Introduzca un valor entero ");
            valorCuenta = Console.ReadLine()!;
        }

        // Solicite al usuario que escriba el primer nombre
        Console.Write("Escriba el primer nombre y luego presione Enter: ");
        nombre = Console.ReadLine()!;

        // Solicite al usuario que escriba el apellido paterno
        Console.Write("Escriba el apellido paterno y luego presione Enter: ");
        apellido = Console.ReadLine()!;

        // Solicite al usuario que escriba el valor del saldo
        Console.Write("Escriba el valor del saldo y luego presione Enter: ");
        valorSaldo = Console.ReadLine()!;

        while (!decimal.TryParse(valorSaldo, out saldo))
        {
            Console.Write("Esta no es una entrada válida. Introduzca un valor decimal ");
            valorSaldo = Console.ReadLine()!;
        }

        registro = new RegistroSerializable(cuenta, nombre, apellido, saldo);
        Console.WriteLine("\n");
        Console.WriteLine("Registro a serializar");
        Console.WriteLine(registro.ToString());

        // Empezamos la serialización
        Console.WriteLine("------------- Serializamos -------------");

        // Serializamos
        formateador.Serialize(miStream, registro);

        // Cerramos el Stream
        miStream.Close();
        break;
    case "d":
        // Deserializamos el objeto
        Console.WriteLine("------------- Deserializamos -------------");

        miStream = new FileStream("clientes.txt", FileMode.Open, FileAccess.Read);

        // Deserializamos
        registro = (RegistroSerializable)formateador.Deserialize(miStream);

        // Cerramos el Stream
        miStream.Close();

        // Usamos el objeto
        Console.WriteLine("El registro deserializado es");
        Console.WriteLine(registro.ToString());
        break;
    default:
        Console.WriteLine("¡Opción inválida!");
        break;
}