namespace TransitInfo.Data.Gtfs.Structs;

public struct Route
{
    public string RouteId { get; set; } // Required
    public string AgencyId { get; set; } // Optional
    public string RouteShortName { get; set; } // Required
    public string RouteLongName { get; set; } // Required
    public string RouteDesc { get; set; } // Optional
    public int RouteType { get; set; } // Required
    public string RouteUrl { get; set; } // Optional
    public string RouteColor { get; set; } // Optional
    public string RouteTextColor { get; set; } // Optional
    public int? RouteSortOrder { get; set; } // Optional
    public int? ContinuousPickup { get; set; } // Optional
    public int? ContinuousDropOff { get; set; } // Optional
}
