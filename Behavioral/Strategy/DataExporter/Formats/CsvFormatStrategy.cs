using System.Text;

namespace DataExporter.Formats;

public class CsvFormatStrategy : IFormatStrategy
{
    public StringBuilder Serialize(List<Dictionary<string, object>> data)
    {
        var sb = new StringBuilder();
        foreach (var key in data[0].Keys)
            sb.Append(key).Append(',');
        sb.AppendLine();
        foreach (var row in data)
        {
            foreach (var value in row.Values)
                sb.Append(value).Append(',');
            sb.AppendLine();
        }
        return sb;
    }
}
