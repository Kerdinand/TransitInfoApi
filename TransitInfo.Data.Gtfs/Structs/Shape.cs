namespace TransitInfo.Data.Gtfs.Structs;

public struct Shape
{
    public string ShapeId { get; set; } // Required
    public double ShapePtLat { get; set; } // Required
    public double ShapePtLon { get; set; } // Required
    public int ShapePtSequence { get; set; } // Required
    public double? ShapeDistTraveled { get; set; } // Optional
}
