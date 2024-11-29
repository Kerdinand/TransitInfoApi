namespace TransitInfo.Data.Gtfs.Structs;

public struct Shape
{
    public string shape_id { get; set; } // Required
    public double shape_pt_lat { get; set; } // Required
    public double shape_pt_lon { get; set; } // Required
    public int shape_pt_sequence { get; set; } // Required
    public double? ShapeDistTraveled { get; set; } // Optional
}
