namespace TransitInfo.Data.Gtfs.Structs;

public struct Calendar
{
    public string ServiceId { get; set; } // Required
    public int Monday { get; set; } // Required
    public int Tuesday { get; set; } // Required
    public int Wednesday { get; set; } // Required
    public int Thursday { get; set; } // Required
    public int Friday { get; set; } // Required
    public int Saturday { get; set; } // Required
    public int Sunday { get; set; } // Required
    public string StartDate { get; set; } // Required
    public string EndDate { get; set; } // Required
}
