**Task:** Apply the Strategy pattern so that each export format is an independent class. The `ReportGenerator` class should accept the strategy via constructor or setter. Make sure the format can be swapped at runtime.

```csharp
public class ReportGenerator
{
    public void GenerateReport(List<Dictionary<string, object>> data, string format)
    {
        if (format == "csv")
        {
            var sb = new StringBuilder();
            foreach (var key in data[0].Keys)
                sb.Append(key).Append(",");
            sb.AppendLine();
            foreach (var row in data)
            {
                foreach (var value in row.Values)
                    sb.Append(value).Append(",");
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
        else if (format == "json")
        {
            var sb = new StringBuilder("[");
            foreach (var row in data)
            {
                sb.Append("{");
                foreach (var entry in row)
                    sb.Append($"\"{entry.Key}\":\"{entry.Value}\",");
                sb.Append("},");
            }
            sb.Append("]");
            Console.WriteLine(sb);
        }
        else if (format == "xml")
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
            Console.WriteLine(sb);
        }
    }
}
```