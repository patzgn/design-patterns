namespace ReportDeliveryPipeline.Solution.DeliveryChannels;

public sealed class SecureFileTransferChannel(string folder, int retryCount) : IReportDeliveryChannel
{
    public string Deliver(RenderedReport report) =>
        $"Uploaded report {report.Id} to {folder} with {retryCount} retry attempts configured.";
}
