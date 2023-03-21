using SerializacionBinaria;
using System.Runtime.Serialization.Formatters.Binary;

BinaryFormatter aplicadorFormato = new BinaryFormatter();
Stream miStream = null;
RegistroSerializable registro = null;
int opcion = 0;
int cuenta = 0;
decimal saldo = 0.0M;

Console.WriteLine("1) Crear y serializar registro"+
    "\n2) Leer registro");
string valor = Console.ReadLine();
while (!int.TryParse(valor, out opcion))
{
    Console.Write("Entrada inválida. Introduzca un valor entero ");
    valor = Console.ReadLine();
}

switch (opcion)
{
    case 1:
        // Creamos el Registro
        Console.Write("Digite el número de la cuenta ");
        valor = Console.ReadLine();
        
        while(!int.TryParse(valor, out cuenta))
        {
            Console.Write("Entrada inválida. Introduzca un valor entero ");
            valor = Console.ReadLine();
        }

        Console.Write("Escriba el primer nombre ");
        string nombre = Console.ReadLine();
        Console.Write("Escriba el apellido paterno ");
        string apellido = Console.ReadLine();
        Console.Write("Digite el saldo de la cuenta ");
        valor = Console.ReadLine();
        
        while(!decimal.TryParse(valor, out saldo))
        {
            Console.Write("Entrada inválida. Introduzca un valor decimal ");
            valor = Console.ReadLine();
        }

        registro = new RegistroSerializable(cuenta,
            nombre, apellido, saldo);

        Console.WriteLine("\n"); // Iterlineado amigable
        Console.WriteLine("Registro a serializar");
        Console.WriteLine(registro.ToString());       

        // Empezamos la serialización
        Console.WriteLine("----- Serializamos -----");

        miStream = new FileStream("clientes.txt", FileMode.OpenOrCreate,
            FileAccess.Write);

        // Serializamos
        aplicadorFormato.Serialize(miStream, registro);

        // Cerramos el Stream
        miStream.Close();     

        break;
    case 2:
        // Deserializamos el objeto
        Console.WriteLine("----- Deserializamos -----");

        miStream = new FileStream("clientes.txt", FileMode.Open, 
            FileAccess.Read);

        // Deserializamos
        registro = (RegistroSerializable)aplicadorFormato.Deserialize(miStream);

        // Cerramos el Stream
        miStream.Close();

        // Usamos el objeto
        Console.WriteLine("El registro deserializado es");
        Console.WriteLine(registro.ToString());
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}
