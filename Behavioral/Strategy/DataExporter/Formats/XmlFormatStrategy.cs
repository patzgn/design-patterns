using System.Text;

namespace DataExporter.Formats;

public class XmlFormatStrategy : IFormatStrategy
{
    public StringBuilder Serialize(List<Dictionary<string, object>> data)
    {
        var sb = new StringBuilder("<report>\n");
        foreach (var row in data)
        {
            sb.AppendLine("  <row>");
            foreach (var entry in row)
                sb.AppendLine($"    <{entry.Key}>{entry.Value}</{entry.Key}>");
            sb.AppendLine("  </row>");
        }
        sb.Append("</report>");
        return sb;
    }
}
