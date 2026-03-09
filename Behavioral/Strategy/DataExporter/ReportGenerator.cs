using DataExporter.Formats;

namespace DataExporter;

public class ReportGenerator
{
    private IFormatStrategy _formatStrategy;

    public ReportGenerator(IFormatStrategy formatStrategy)
    {
        _formatStrategy = formatStrategy;
    }

    public void SetFormatStrategy(IFormatStrategy formatStrategy)
    {
        _formatStrategy = formatStrategy;
    }

    public void GenerateReport(List<Dictionary<string, object>> data)
    {
        var output = _formatStrategy.Serialize(data);
        Console.WriteLine(output);
    }
}
