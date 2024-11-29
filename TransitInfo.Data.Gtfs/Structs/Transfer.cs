namespace TransitInfo.Data.Gtfs.Structs;

public struct Transfer
{
    public string FromStopId { get; set; } // Required
    public string ToStopId { get; set; } // Required
    public int TransferType { get; set; } // Required
    public int? MinTransferTime { get; set; } // Optional
}
