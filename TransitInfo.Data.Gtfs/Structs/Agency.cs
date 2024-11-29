namespace TransitInfo.Data.Gtfs.Structs;

public struct Agency
{
    public string agency_id { get; set; } // Optional
    public string agency_name { get; set; } // Required
    public string agency_url { get; set; } // Required
    public string agency_timezone { get; set; } // Required
    public string agency_lang { get; set; } // Optional
    public string agency_phone { get; set; } // Optional
    public string agency_fare_url { get; set; } // Optional
    public string agency_email { get; set; } // Optional
}
