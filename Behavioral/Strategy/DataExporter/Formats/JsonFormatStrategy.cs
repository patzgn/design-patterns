using System.Text;

namespace DataExporter.Formats;

public class JsonFormatStrategy : IFormatStrategy
{
    public StringBuilder Serialize(List<Dictionary<string, object>> data)
    {
        var sb = new StringBuilder("[");
        foreach (var row in data)
        {
            sb.Append('{');
            foreach (var entry in row)
                sb.Append($"\"{entry.Key}\":\"{entry.Value}\",");
            sb.Append("},");
        }
        sb.Append(']');
        return sb;
    }
}
