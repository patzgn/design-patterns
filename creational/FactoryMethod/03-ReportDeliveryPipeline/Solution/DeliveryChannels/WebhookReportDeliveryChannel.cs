namespace ReportDeliveryPipeline.Solution.DeliveryChannels;

public sealed class WebhookReportDeliveryChannel(string endpoint, string sourceHeader) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Posted report {report.Id} to {endpoint} using header {sourceHeader}.";
}
