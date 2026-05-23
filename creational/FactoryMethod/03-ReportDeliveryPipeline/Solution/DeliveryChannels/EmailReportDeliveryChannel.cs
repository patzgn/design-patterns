namespace ReportDeliveryPipeline.Solution.DeliveryChannels;

public sealed class EmailReportDeliveryChannel(string recipient, string classification) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Email sent to {recipient} with classification '{classification}' for report {report.Id}.";
}
