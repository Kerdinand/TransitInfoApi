namespace TransitInfo.Data.Gtfs.Structs;

public struct Trip
{
    public string RouteId { get; set; } // Required
    public string ServiceId { get; set; } // Required
    public string TripId { get; set; } // Required
    public string TripHeadsign { get; set; } // Optional
    public string TripShortName { get; set; } // Optional
    public int? DirectionId { get; set; } // Optional
    public string BlockId { get; set; } // Optional
    public string ShapeId { get; set; } // Optional
    public int? WheelchairAccessible { get; set; } // Optional
    public int? BikesAllowed { get; set; } // Optional
}
