using TransitInfo.Data.Gtfs;
using TransitInfo.Data.Gtfs.IO;
using TransitInfo.Data.Gtfs.Structs;

namespace TransitInfo.GtfsReader.Lib;

public class GeoJsonBuilder
{
    public GeoJsonBuilder()
    {
    }

    public void SaveShapeJsonToFile(string input, string output)
    {
        var content = new Reader().Read<Shape>(input);
        var data = new ShapeDataStore();
        foreach (var entry in content)
        {
            data.AddEntry(entry);
        }
        
        new Writer().Write<ShapeDataStore>(output, data);
    }
}