namespace TransitInfo.Data.Gtfs.Structs;

public struct CalendarDate
{
    public string ServiceId { get; set; } // Required
    public string Date { get; set; } // Required
    public int ExceptionType { get; set; } // Required
}
