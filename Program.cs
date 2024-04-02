// Crear una persona para serializar

using SerializacionXML;

Persona persona = new Persona 
{
    PrimerNombre = "Juan",
    SegundoNombre = "Carlos",
    PrimerApellido = "Cardoza",
    SegundoApellido = "Solís",
    Edad = 18
};

// Usar factory de serialización XML

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
    "Nombre = {0} {1} ," +
    "Apellido = {2} {3} ," +
    "Edad = {4}", personaFromXML.PrimerNombre, personaFromXML.SegundoNombre,
    personaFromXML.PrimerApellido, personaFromXML.SegundoApellido,
    personaFromXML.Edad);
