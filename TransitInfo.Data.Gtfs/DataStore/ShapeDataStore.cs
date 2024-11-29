using System.Text.Json.Serialization;
using TransitInfo.Data.Gtfs.Structs;

namespace TransitInfo.Data.Gtfs;

public class ShapeDataStore
{
    public ShapeDataStore()
    {
    }

    [JsonInclude]
    private Dictionary<string, List<Shape>> data = new Dictionary<string, List<Shape>>();

    public void AddEntry(Shape entry)
    {
        if (!data.ContainsKey(entry.shape_id)) data.Add(entry.shape_id, new List<Shape>());
        data[entry.shape_id].Add(entry);
    }

    public List<Shape> GetEntry(string key)
    {
        if (data.ContainsKey(key)) return data[key];
        throw new KeyNotFoundException();
    }
}