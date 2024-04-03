
// Crear una persona para serializar
using Serializacion;

Persona persona = new Persona
{
    PrimerNombre = "María",
    SegundoNombre = "José",
    PrimerApellido = "Guevara",
    SegundoApellido = "Palacios",
    Edad = 18,
    Genero = "Femenino"
};

// Serialización XML
ISerializerFactory xmlSerializerFactory 
    = new XmlSerializerFactory();
ObjectSerializer xmlObjectSerializer 
    = new ObjectSerializer(xmlSerializerFactory);
xmlObjectSerializer.Serialize(persona, "persona.xml");

// Deserializar persona desde XML
Persona personaFromXML
    = xmlObjectSerializer.Deserialize<Persona>("persona.xml");
Console.WriteLine(
    "Persona desde XML: " +
    "Nombre = {0} {1}, " +
    "Apellido = {2} {3}, " +
    "Edad = {4}, " +
    "Género = {5}",
    personaFromXML.PrimerNombre, personaFromXML.SegundoNombre,
    personaFromXML.PrimerApellido, personaFromXML.SegundoApellido,
    personaFromXML.Edad, personaFromXML.Genero);

// Serialización JSON
ISerializerFactory jsonSerializerFactory
    = new JsonSerializerFactory();
ObjectSerializer jsonObjectSerializer
    = new ObjectSerializer(jsonSerializerFactory);
jsonObjectSerializer.Serialize(persona, "persona.json");

// Deserializar persona desde JSON
Persona personaFromJSON
    = jsonObjectSerializer.Deserialize<Persona>("persona.json");
Console.WriteLine(
    "Persona desde JSON: " +
    "Nombre = {0} {1}, " +
    "Apellido = {2} {3}, " +
    "Edad = {4}, " +
    "Género = {5}",
    personaFromJSON.PrimerNombre, personaFromJSON.SegundoNombre,
    personaFromJSON.PrimerApellido, personaFromJSON.SegundoApellido,
    personaFromJSON.Edad, personaFromJSON.Genero);