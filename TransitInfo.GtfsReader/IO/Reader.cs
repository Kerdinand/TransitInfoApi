using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace TransitInfo.Data.Gtfs.IO;

public class Reader
{
    public List<T> Read<T>(string path)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null
        };
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, config))
        {
            return csv.GetRecords<T>().ToList();
        }
    }

    public List<T> Read<T>(string path, CsvConfiguration config)
    {
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, config))
        {
            return csv.GetRecords<T>().ToList();
        }
    }
    
    public Reader()
    {
    }
}