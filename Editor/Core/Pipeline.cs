namespace Editor.Models
{
    public static class Pipeline
    {
        public static T Read<T>(string fileName)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(fileName);

            var data = File.ReadAllText(fileName);
            var model = FileSerializer.Deserializer<T>(data);

            return model;
        }

        public static void Write<T>(string fileName, T model) 
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));
            
            var directory = Path.GetDirectoryName(fileName);

            ArgumentException.ThrowIfNullOrWhiteSpace(directory, nameof(fileName));

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var stream = File.Create(fileName);
            stream.Close();

            var data = FileSerializer.Serializer(model);

            File.WriteAllText(fileName, data);
        }
    }
}
