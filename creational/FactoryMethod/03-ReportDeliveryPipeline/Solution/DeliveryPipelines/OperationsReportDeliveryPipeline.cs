using ReportDeliveryPipeline.Solution.DeliveryChannels;

namespace ReportDeliveryPipeline.Solution.DeliveryPipelines;

public class OperationsReportDeliveryPipeline : ReportDeliveryPipeline
{
    protected override IReportDeliveryChannel CreateDeliveryChannel()
    {
        return new WebhookReportDeliveryChannel("https://ops.example.com/reports", "X-Report-Source");
    }
}
