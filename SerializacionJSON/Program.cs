
using System.Text.Json;

Console.WriteLine("Serialización JSON en C#\r");
Console.WriteLine("------------------------\n");

RegistroSerializable registro = null;
int cuenta = 0;
string valorCuenta = "";
string nombre = "";
string apellido = "";
decimal saldo = 0.0M;
string valorSaldo = "";
string nombreArchivo = "clientes.json";
string jsonString = "";

// Solicite al usuario que elija una opción
Console.WriteLine("Elija una opción de la siguiente lista:");
Console.WriteLine("\ts - Crear y serializar registro");
Console.WriteLine("\td - Deserializar registro");
Console.Write("¿Su opción? ");

string op = Console.ReadLine()!;

switch (op)
{
    case "s":
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
        jsonString = JsonSerializer.Serialize(registro);
        File.WriteAllText(nombreArchivo, jsonString);

        break;
    case "d":
        // Deserializamos el objeto
        Console.WriteLine("------------- Deserializamos -------------");

        // Deserializamos
        jsonString = File.ReadAllText(nombreArchivo);
        registro = JsonSerializer.Deserialize<RegistroSerializable>(jsonString)!;

        // Usamos el objeto
        Console.WriteLine("El registro deserializado es");
        Console.WriteLine(registro.ToString());
        break;
    default:
        Console.WriteLine("¡Opción inválida!");
        break;
}

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