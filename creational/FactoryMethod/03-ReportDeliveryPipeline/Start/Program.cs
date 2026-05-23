var reports = new[]
{
    new ReportRequest("R-7001", "finance", "Quarterly revenue", "Revenue grew by 8 percent."),
    new ReportRequest("R-7002", "partner", "Partner inventory", "Inventory sync completed."),
    new ReportRequest("R-7003", "operations", "Nightly incident summary", "No critical incidents.")
};

var pipeline = new ReportDeliveryPipeline();

foreach (var report in reports)
{
    Console.WriteLine(pipeline.Deliver(report));
    Console.WriteLine();
}

public sealed class ReportDeliveryPipeline
{
    public string Deliver(ReportRequest request)
    {
        Validate(request);
        var renderedReport = Render(request);

        IReportDeliveryChannel channel = request.Audience switch
        {
            "finance" => new EmailReportDeliveryChannel("finance-reports@example.com", "Confidential"),
            "partner" => new SecureFileTransferChannel("/partners/inbound/reports", 3),
            "operations" => new WebhookReportDeliveryChannel("https://ops.example.com/reports", "X-Report-Source"),
            _ => throw new ArgumentException($"Unsupported audience: {request.Audience}")
        };

        var deliveryResult = channel.Deliver(renderedReport);
        var auditEntry = $"Audit: report {request.Id} delivered to {request.Audience}.";

        return $"{deliveryResult}{Environment.NewLine}{auditEntry}";
    }

    private static void Validate(ReportRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Body))
        {
            throw new ArgumentException("Report body cannot be empty.");
        }
    }

    private static RenderedReport Render(ReportRequest request) =>
        new(request.Id, $"# {request.Title}{Environment.NewLine}{request.Body}");
}

public sealed record ReportRequest(string Id, string Audience, string Title, string Body);

public sealed record RenderedReport(string Id, string Content);

public interface IReportDeliveryChannel
{
    string Deliver(RenderedReport report);
}

public sealed class EmailReportDeliveryChannel(string recipient, string classification) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Email sent to {recipient} with classification '{classification}' for report {report.Id}.";
}

public sealed class SecureFileTransferChannel(string folder, int retryCount) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Uploaded report {report.Id} to {folder} with {retryCount} retry attempts configured.";
}

public sealed class WebhookReportDeliveryChannel(string endpoint, string sourceHeader) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Posted report {report.Id} to {endpoint} using header {sourceHeader}.";
}

