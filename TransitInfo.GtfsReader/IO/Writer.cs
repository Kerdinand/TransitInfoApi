using System.Text.Json;

namespace TransitInfo.Data.Gtfs.IO;

public class Writer
{
    public void Write<T>(string path, T content)
    {
        var json = JsonSerializer.Serialize(content);
        File.WriteAllText(path, json);
    }

    public Writer()
    {
    }
}