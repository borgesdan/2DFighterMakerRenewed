using System.Text.Json;

namespace Editor.Core
{
    public static class FileSerializer
    {
        public static string Serializer<T>(T model)
        {
            var json = JsonSerializer.Serialize(model, typeof(T));
            return json;
        }

        public static T Deserializer<T>(string data) 
        {
            var model = JsonSerializer.Deserialize<T>(data);
            return model;
        }
    }
}
