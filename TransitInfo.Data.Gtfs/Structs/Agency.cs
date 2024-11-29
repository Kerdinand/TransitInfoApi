namespace TransitInfo.Data.Gtfs.Structs;

public struct Agency
{
    public string AgencyId { get; set; } // Optional
    public string AgencyName { get; set; } // Required
    public string AgencyUrl { get; set; } // Required
    public string AgencyTimezone { get; set; } // Required
    public string AgencyLang { get; set; } // Optional
    public string AgencyPhone { get; set; } // Optional
    public string AgencyFareUrl { get; set; } // Optional
    public string AgencyEmail { get; set; } // Optional
}
