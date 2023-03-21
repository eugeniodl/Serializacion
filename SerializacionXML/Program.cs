using System.Xml.Serialization;

Console.WriteLine("Serialización XML en C#\r");
Console.WriteLine("-----------------------\n");

XmlSerializer formateador = new XmlSerializer(typeof(RegistroSerializable));
Stream stream = null;
RegistroSerializable registro = null;
int cuenta;
string valorCuenta = "";
string nombre = "";
string apellido = "";
decimal saldo = 0.0M;
string valorSaldo = "";

// Pídale al usuario que elija una opción
Console.WriteLine("Elija una opción de la siguiente lista:");
Console.WriteLine("\ts - Crear y serializar registro");
Console.WriteLine("\td - Deserializar registro");
Console.Write("¿Su opción? ");

string op = Console.ReadLine();

switch (op)
{
    case "s":
        // Se crea el Stream
        stream = new FileStream("clientes.xml", FileMode.OpenOrCreate,
            FileAccess.Write);

        // Creamos el objeto de registro

        // Pida al usuario que escriba el número de la cuenta.
        Console.Write("Escriba el número de la cuenta y luego presione Enter: ");
        valorCuenta = Console.ReadLine();

        while (!int.TryParse(valorCuenta, out cuenta))
        {
            Console.Write("Esta entrada no es válida. Introduzca un valor entero: ");
            valorCuenta = Console.ReadLine();
        }

        // Pida al usuario que escriba el primer nombre
        Console.Write("Escriba el primer nombre y luego presione Enter: ");
        nombre = Console.ReadLine();

        // Pida al usuario que escriba el apellido paterno
        Console.Write("Escriba el apellido paterno y luego presione Enter: ");
        apellido = Console.ReadLine();

        // Pida al usuario que escriba el valor del saldo
        Console.Write("Escriba el valor del saldo y luego presione Enter: ");
        valorSaldo = Console.ReadLine();

        while (!decimal.TryParse(valorSaldo, out saldo))
        {
            Console.Write("Esta entrada no es válida. Introduzca un valor decimal ");
            valorSaldo = Console.ReadLine();
        }

        registro = new RegistroSerializable(cuenta, nombre, apellido,
            saldo);

        Console.WriteLine("\n");
        Console.WriteLine("Registro a serializar");
        Console.WriteLine(registro.ToString());

        // Empezamos la serialización
        Console.WriteLine("-------------- Serializamos --------------");

        // Serializamos
        formateador.Serialize(stream, registro);

        // Cerramos el Stream
        stream.Close();

        break;
    case "d":
        // Deserialziamos el objeto
        Console.WriteLine("-------------- Deserializamos --------------");

        // Abrimos Stream
        stream = new FileStream("clientes.xml", FileMode.Open,
            FileAccess.Read);

        //Deserializamos
        registro = (RegistroSerializable)formateador.Deserialize(stream);

        // Cerramos el Stream
        stream.Close();

        // Usamos el objeto
        Console.WriteLine("El registro deserializado es");
        Console.WriteLine(registro.ToString());

        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}


[Serializable]
public class RegistroSerializable
{
    private int cuenta;
    private string primerNombre;
    private string apellidoPaterno;
    private decimal saldo;

    public RegistroSerializable() : this(0, "", "", 0.0M)
    {

    }

    public RegistroSerializable(int valorCuenta, string valorPrimerNombre,
        string valorApellidoPaterno, decimal valorSaldo)
    {
        Cuenta = valorCuenta;
        PrimerNombre = valorPrimerNombre;
        ApellidoPaterno = valorApellidoPaterno;
        Saldo = valorSaldo;
    }

    public int Cuenta { get => cuenta; set => cuenta = value; }
    public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
    public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
    public decimal Saldo { get => saldo; set => saldo = value; }

    public override string ToString()
    {
        return "Cuenta: " + Cuenta + "\n" +
            "Nombre: " + PrimerNombre + "\n" +
            "Apellido: " + ApellidoPaterno + "\n" +
            "Saldo: " + Saldo + "\n";
    }
}