namespace TransitInfo.Data.Gtfs.Structs;

public struct Stop
{
    public string StopId { get; set; } // Required
    public string StopCode { get; set; } // Optional
    public string StopName { get; set; } // Required
    public string StopDesc { get; set; } // Optional
    public double StopLat { get; set; } // Required
    public double StopLon { get; set; } // Required
    public string ZoneId { get; set; } // Optional
    public string StopUrl { get; set; } // Optional
    public int? LocationType { get; set; } // Optional
    public string ParentStation { get; set; } // Optional
    public string StopTimezone { get; set; } // Optional
    public int? WheelchairBoarding { get; set; } // Optional
    public string LevelId { get; set; } // Optional
    public string PlatformCode { get; set; } // Optional
}
