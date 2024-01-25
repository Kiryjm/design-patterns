using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.Reflection;
using GroBuf;
using GroBuf.DataMembersExtracters;

public static class ExtensionMethods
{
    public static T? DeepCopy<T>(this T self)
    {
        if (self == null)
            return default;

        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        using (var stream = new MemoryStream())
        {

            /*


             BinaryFormatter Serialize method now is obsolete!!!


            */

            // BinaryFormatter formatter = new BinaryFormatter();
            // formatter.Serialize(stream, self);
            // stream.Seek(0, SeekOrigin.Begin);
            // object copy = formatter.Deserialize(stream);

            // return (T) copy;

            /*


                JsonSerializer seems to be not deep copying objects!


            */

            // JsonSerializer.Serialize(stream, self);
            // stream.Seek(0, SeekOrigin.Begin);

            // T deserializedObject = JsonSerializer.Deserialize<T>(stream);

            // return DeepCopyHelper(deserializedObject);

            /*


                Grobuf binary serializer also doesn't clone deeply

            */
            Serializer serializer = new Serializer((IDataMembersExtractor)new PropertiesExtractor());
            return serializer.Deserialize<T>(serializer.Serialize<T>(self));

        }
    }

    private static T DeepCopyHelper<T>(T source)
    {
        if (source == null)
            return default;

        var methodInfo = typeof(Program).GetMethod("DeepCopyHelper", BindingFlags.NonPublic | BindingFlags.Static);
        if (methodInfo == null)
            throw new InvalidOperationException("DeepCopyHelper method not found.");


        if (typeof(T).IsClass && typeof(T) != typeof(string))
        {
            var properties = typeof(T).GetProperties();
            var fields = typeof(T).GetFields();

            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;

                if (propertyType.IsClass && propertyType != typeof(string))
                {
                    var nestedPropertyValue = property.GetValue(source);
                    var deepCopyMethod = typeof(ExtensionMethods).GetMethod("DeepCopy", BindingFlags.Public | BindingFlags.Static);
                    if (deepCopyMethod == null)
                        throw new InvalidOperationException("DeepCopy method not found.");

                    var deepCopyValue = deepCopyMethod.Invoke(null, new[] { nestedPropertyValue });
                    property.SetValue(source, deepCopyValue);
                }
            }

            foreach (var field in fields)
            {
                var fieldType = field.FieldType;

                // if (fieldType.IsClass && fieldType != typeof(string))
                // {
                var nestedFieldValue = field.GetValue(source);
                var deepCopyMethod = typeof(ExtensionMethods).GetMethod("DeepCopy", BindingFlags.Public | BindingFlags.Static);
                if (deepCopyMethod == null)
                    throw new InvalidOperationException("DeepCopy method not found.");

                var deepCopyValue = deepCopyMethod.Invoke(null, new[] { nestedFieldValue });
                field.SetValue(source, deepCopyValue);
                // }
            }
        }

        return source;
    }



    // XmlSerializer cannot serialize Dictionary !!!
    public static T DeepCopyXml<T>(this T self)
    {
        using (var ms = new MemoryStream())
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            s.Serialize(ms, self);
            ms.Position = 0;

            return (T)s.Deserialize(ms);
        }
    }
}