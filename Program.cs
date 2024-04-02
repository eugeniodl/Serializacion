// Crear una persona para serializar

using Serializacion;

Persona persona = new Persona 
{
    PrimerNombre = "José",
    SegundoNombre = "María",
    PrimerApellido = "Cruz",
    SegundoApellido = "Poveda",
    Edad = 19
};

// Serializar persona en XML
ISerializerFactory xmlSerializerFactory 
    = new XmlSerializerFactory();
ObjectSerializer xmlObjectSerializer = 
    new ObjectSerializer(xmlSerializerFactory);
xmlObjectSerializer.Serialize(persona, "persona.xml");


// Deserializar persona desde XML
Persona personaFromXML =
    xmlObjectSerializer.Deserialize<Persona>("persona.xml");

Console.WriteLine(
    "Persona desde XML: Nombre = {0} {1}, " +
    "Apellido = {2} {3}, " +
    "Edad = {4}", personaFromXML.PrimerNombre,
    personaFromXML.SegundoNombre,
    personaFromXML.PrimerApellido,
    personaFromXML.SegundoApellido,
    personaFromXML.Edad);
