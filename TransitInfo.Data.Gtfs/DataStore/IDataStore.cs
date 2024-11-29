namespace TransitInfo.Data.Gtfs;

public interface IDataStore
{
    public bool AddEntry<T>(T entry);

    public bool GetEntry<T>(T key);
}