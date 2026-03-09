using System.Text;

namespace DataExporter.Formats;

public interface IFormatStrategy
{
    StringBuilder Serialize(List<Dictionary<string, object>> data);
}
