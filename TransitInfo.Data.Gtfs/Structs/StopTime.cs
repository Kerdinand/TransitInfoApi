namespace TransitInfo.Data.Gtfs.Structs;

public struct StopTime
{
    public string TripId { get; set; } // Required
    public string ArrivalTime { get; set; } // Required
    public string DepartureTime { get; set; } // Required
    public string StopId { get; set; } // Required
    public int StopSequence { get; set; } // Required
    public string StopHeadsign { get; set; } // Optional
    public int? PickupType { get; set; } // Optional
    public int? DropOffType { get; set; } // Optional
    public double? ShapeDistTraveled { get; set; } // Optional
    public int? Timepoint { get; set; } // Optional
}
